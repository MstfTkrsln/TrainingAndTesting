using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace XMLSerialization
{
    class Program
    {
        static string strPersonelData;


        static void Main(string[] args)
        {
            #region XML Yazma
            Personel yeniPersonel = new Personel();

            // Personel Bilgilerini Personel nesnesine kaydediyoruz. 

            yeniPersonel.Ad = "Mustafa";
            yeniPersonel.Departman = "Yazılım";
            yeniPersonel.Email = "mustafa.tekeraslan@gmail.com";
            yeniPersonel.Yas = 26;
            yeniPersonel.GirisTarihi = Convert.ToDateTime("01.01.2014");

            // Maaş Bilgilerini Personel sınıfı altında tutmak için 
            // yeni bir Para Sınıfı yaratıyor ve Bilgileri kaydediyoruz. 

            yeniPersonel.Maas = new Para();
            yeniPersonel.Maas.Tutar = 1000;
            yeniPersonel.Maas.Birim = "TL";

            // Serialize edilmiş olan nesneyi tutacak değişkene fonksiyonumuzun 
            // geri dönüş değerini atıyoruz ve Messagebox kullanarak gösteriyoruz.

            strPersonelData = SerializeObject(yeniPersonel);
            Console.WriteLine(strPersonelData);

            #endregion


            #region XML Okuma

            Console.WriteLine("\n*********************************\n");
            DeserializeXml(strPersonelData);


            #endregion
            Console.ReadLine();



        }
        
        private static string SerializeObject(Personel PersObject)
        {
            // Yeni bir XmlSerializer nesnesi yaratıyoruz ve Serialize 
            // edilecek sınıfımızın adını Constructor parametresi olarak gönderiyoruz. 

            XmlSerializer MySerializer = new XmlSerializer(typeof(Personel));

        


            // XML olarak Serialize edilmiş nesnemizi tutacak olan StringWriter yaratıyoruz. 
            //TextWriter TW = new StringWriter();

            FileStream fs=new FileStream(@"XML Document.txt",FileMode.Create,FileAccess.ReadWrite);
            StreamWriter sw=new StreamWriter(fs);
            StreamReader sr=new StreamReader(fs);

            // Yarattığımız XmlSerializerın Serialize Metodunu kullanarak 
            // nesnemizi Serialize ediyoruz. 
            MySerializer.Serialize(sw, PersObject);

            // Serialize edilmiş nesneyi geri döndürüyoruz.
            fs.Position = 0;
            string xmlveri = sr.ReadToEnd();

            fs.Dispose();
            return xmlveri;


        }


        // Deserialization işlemi için kullanılacak olan metod 
        private static void DeserializeXml(string XmlData)
        {
            // Yeni bir Personel Nesnesi Yaratıyoruz Personel ReturnedEmployee;  
            // DeSerialize işleminde kullanılmak üzere yeni bir XmlSerializer  
            // nesnesi yaratıyor ve Serialize edilmiş verinin hangi nesne(Class) tipine çevirileceğini gösteriyoruz.  
            XmlSerializer MyDeserializer = new XmlSerializer(typeof(Personel));

            FileStream fs = new FileStream(@"XML Document.txt",FileMode.Open, FileAccess.Read);
            // XML Verisini tutmak için bir StringReader yaratıyoruz.   
           
            StreamReader sr=new StreamReader(fs);
            XmlReader XR = new XmlTextReader(sr);
            

            // XML verisinin Deserialize edilip edilmeyeceğini kontrol ediyoruz.   
            if (MyDeserializer.CanDeserialize(XR))
            {
                // Ve XML verisini Deserialize ediyoruz.  
                Personel ReturnedEmployee = (Personel)MyDeserializer.Deserialize(XR);
                ShowEmployeeData(ReturnedEmployee);
            }
            
            fs.Dispose();
        }

        // Geri dönüş değerini düzgün bir hale getirmek için kullandığımız metod 
        private static void ShowEmployeeData(Personel PersObject)
        {
            // Veriyi düzgün bir şekilde göstermek için StringiBuilder sınıfı ve  
            // bu sınıfın Append metodunu kullanıyoruz.  
            StringBuilder OutputString = new StringBuilder("Personel Bilgileri: \r\n");

            OutputString.Append("Adı: " + PersObject.Ad + "\r\n");
            OutputString.Append("Departmanı: " + PersObject.Departman + "\r\n");
            OutputString.Append("Email: " + PersObject.Email + "\r\n");
            OutputString.Append("Yaşı: " + PersObject.Yas.ToString() + "\r\n");
            OutputString.Append("İşe Başlangıç Tarihi: " + PersObject.GirisTarihi.ToString() + "\r\n");
            OutputString.Append("Maaşı: " + PersObject.Maas.Tutar + " " + PersObject.Maas.Birim + "\r\n");

           

            Console.WriteLine(OutputString.ToString());
            
        }
    }
}
