using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Lucene.Net.Analysis;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.QueryParsers;
using Lucene.Net.Search;
using Version = Lucene.Net.Util.Version;
using ld = Lucene.Net.Store;

namespace LuceneTest
{
    class Program
    {

        const string cnnstr= "Data Source=.;Application Name=SolrReis;Initial Catalog=orman;User ID=some;Password=some;Max Pool Size=500;";
        static void Main(string[] args)
        {

            string indeksYolu = @"D:\LuceneDocumentStatic";
            Directory.CreateDirectory(indeksYolu);

            ld.Directory indexed = new ld.SimpleFSDirectory(new DirectoryInfo(indeksYolu));

            // indeks'in oluşturulacağı klasörü oluşturuyoruz. 
            // Projeyi çalıştırdıktan sonra bu adrese gidip oluşan dosyaları görebilirsiniz.  // İndeksleme yapıyoruz. Projeyi bir kere çalıştırdıktan sonra tekrar çalıştırırsanız ikinci defa indeksleme yapacaktır. 
            // Bu da aynı ürünü n defa indexlemiş olmak anlamına geliyor. o yüzden ilk çalıştırmadan sonra bu kısmı commentlemeniz gerekiyor.

            //Indeksleme(indexed);
            
            SqlArama("NTV");
            LuceneArama(indexed, "NTV");
            Console.ReadLine();
        }


        private static void Indeksleme(ld.Directory indeksYolu)
        {


            Analyzer analyzer = new StandardAnalyzer(Version.LUCENE_CURRENT);
            using (analyzer)
            {


                var indeksYazici = new IndexWriter(indeksYolu, analyzer, IndexWriter.MaxFieldLength.UNLIMITED);

                using (SqlConnection sqlConn = new SqlConnection())
                {

                    sqlConn.ConnectionString = cnnstr;
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand("Select Id,Name From DocumentFeaturesStatic", sqlConn);
                    SqlDataReader oku = cmd.ExecuteReader();


                    DateTime indexBaslangic = DateTime.Now;
                    Console.WriteLine("İndeksleme başlıyor => " + indexBaslangic);

                    while (oku.Read())
                    {
                        Console.WriteLine(oku["Id"]);
                        Console.WriteLine(oku["Name"]);

                        var doc = new Document();
                        doc.Add(new Field("Id", oku["Id"].ToString(), Field.Store.YES, Field.Index.NO));
                        // Id' kolonu dökümanda yer alsın ama indekslenmesin diyoruz

                        doc.Add(new Field("Name", oku["Name"].ToString(), Field.Store.YES, Field.Index.ANALYZED));
                        //ProductName kolonu indekslensin

                        indeksYazici.AddDocument(doc);
                    }
                    indeksYazici.Optimize();
                    indeksYazici.Commit();
                    DateTime indexBitis = DateTime.Now;
                    Console.WriteLine("İndeksleme bitti => " + indexBitis);
                    Console.WriteLine("Süre: " + (indexBitis - indexBaslangic));
                    Console.WriteLine("İndekslenen döküman sayısı: " + indeksYazici.GetDocCount(0));
                    indeksYazici.Close();
                }
            }
        }

        private static void LuceneArama(ld.Directory indeksYolu, string metin)
        {

            Analyzer analyzer = new StandardAnalyzer(Version.LUCENE_CURRENT);

            var parser = new QueryParser(Version.LUCENE_CURRENT, "Name",analyzer);
            //parser.AllowLeadingWildcard = true;
            Query query = parser.Parse(metin);

            // döküman içindeki Name isimli Field'da verilen metin değerini arayacak bir sorgu oluşturduk.
            
            var aramaAraci = new IndexSearcher(indeksYolu, true);
            
            // yukardaki oluşturduğumuz sorguyu, verilen indeks yolundaki dökümanda arayacak.

            DateTime baslangic = DateTime.Now;
            Console.WriteLine("Lucene arama başladı =>" + baslangic);

            TopDocs hits = aramaAraci.Search(query, 100);
            //Arama yapılır

            DateTime bitis = DateTime.Now;
            Console.WriteLine("Lucene arama bitti =>" + bitis);
            Console.WriteLine("Süre: " + (bitis - baslangic));
            int sounucSayisi = hits.TotalHits;
            Console.WriteLine("Yapılan aramada {0} sonuç bulundu", sounucSayisi);

            aramaAraci.Close();

        }


        static void SqlArama(string metin)
        {

            SqlConnection sqlConn = new SqlConnection();
            sqlConn.ConnectionString = cnnstr;
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("Select Id From DocumentFeaturesStatic where Name like '%"+metin+"%'", sqlConn);
            SqlDataReader oku = cmd.ExecuteReader();

            DateTime baslangic = DateTime.Now;
            Console.WriteLine("Sql arama başlıyor => " + baslangic);

            DataTable dt = new DataTable();
            dt.Load(oku);

            DateTime bitis = DateTime.Now;
            Console.WriteLine("İndeksleme bitti => " + bitis);
            Console.WriteLine("Süre: " + (bitis - baslangic));
            Console.WriteLine("Yapılan aramada {0} sonuç bulundu", dt.Rows.Count);

            sqlConn.Close();
        }
    }
}

