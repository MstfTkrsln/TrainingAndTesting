using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Caching;
using System.Windows;
using System.Data; 

namespace CacheConceptApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        string filePath = Path.Combine(Environment.CurrentDirectory, "test.pdf");
       
        // In-Memory Caching için kullanılacak olan nesne örneklenir 
        private MemoryCache mCache = MemoryCache.Default;
       

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void buttonAddCache_Click(object sender, RoutedEventArgs e)
        {
            ObjectCache oCache = MemoryCache.Default;

           

            #region DosyaCache
            // Dosya bazlı bir bağımlılık politikası üretimi 
            CacheItemPolicy policy = new CacheItemPolicy(); // Önce Policy tipi oluşturulur

            // Policy tipi için yeni bir dosya değişikliğini takip eden monitor nesnesi eklenir 
            HostFileChangeMonitor cMonitor = new HostFileChangeMonitor(new List<string> { filePath });

            // Monitor örneğin ilkelere eklenir 
            policy.ChangeMonitors.Add(cMonitor);
            policy.AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(15);

            // Ön belleğe PDF tipinden olan dosya bir byte[] dizisi şeklinde eklenir. İkinci parametre de dependency belirtilir 
            byte[] bytes = File.ReadAllBytes(filePath);
            mCache.Add("Aspnet40", bytes, policy); 
            #endregion
            
            #region Class Cache
            // Custom Type türevli bir örneğin ön belleğe eklenmesi 
            Person person1 = new Person();
            person1.Name = "Mustafa";
            person1.Surname = "TEKERASLAN";
            person1.Salary = 1000;
            person1.BirthDate = new DateTime(1989, 1, 1);

            mCache.Add("Person", person1, DateTimeOffset.Now.AddSeconds(30));
            // Eklenme anından itibaren 30 saniye süreyle ön bellekte tutulacağı DateTimeOffset yardımıyla belirtilir 
            #endregion
            
            #region DB Cache
            // Ön belleğe DataTable türünden bir nesne örneğinin eklenmesi 
            DataTable table = new DataTable();
            using (SqlConnection conn = new SqlConnection("data source=(local);database=Northwnd;integrated security=SSPI"))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("Select * From Products", conn);
                adapter.Fill(table);
            }
            mCache.Add("Products", table, DateTimeOffset.Now.AddMinutes(1));
            // DataTable içeriği eklenme anından itibaren iki dakika süreyle ön bellekte tutulacaktır  
            #endregion

            MessageBox.Show("Cache'e Kaydedildi");  
        }
        

        private void GetDashboard()
        {
            // Fiziksel olarak ön bellek ile ilişkili bazı bilgilerin çekilmesi 
            lstHistories.Items.Add(String.Format("Cache için kullanılabilecek bellek oranı %{0} ", mCache.PhysicalMemoryLimit));
            lstHistories.Items.Add(String.Format("Cache için kullanılabilecek bellek miktarı {0}", mCache.CacheMemoryLimit));
            lstHistories.Items.Add(String.Format("Cache içerisindeki nesne sayısı {0}", mCache.GetCount()));
        }


        private void buttonGetCache_Click(object sender, RoutedEventArgs e)
        {
            lstHistories.Items.Clear();
            
            
            GetDashboard();
            // byte[] tipinden ön belleklenmiş olan PDF dosyasının elde edilişi 

            CacheItem cItem = mCache.GetCacheItem("Aspnet40");
            if (cItem != null)
            {
                byte[] cValue = cItem.Value as byte[];
                lstHistories.Items.Add(String.Format("Cache deki {0} key değerli nesnenin boyutu {1}", cItem.Key, cValue.Length));
            }

            // Person tipinden ön belleklenen nesnenin elde edilişi 
            CacheItem cItemPerson = mCache.GetCacheItem("Person");
       
            if (cItemPerson != null)
            {
                Person cachedPerson = cItemPerson.Value as Person;
            
                lstHistories.Items.Add(String.Format("Cache deki {0} key değerli nesnenin Name değeri {1}", cItemPerson.Key, cachedPerson.Name));
            }

            // DataTable tipinden ön belleklenen nesnenin elde edilişi 
            CacheItem cItemTable = mCache.GetCacheItem("Products");
            if (cItemTable != null)
            {
                DataTable table = cItemTable.Value as DataTable;
                lstHistories.Items.Add(String.Format("Cache deki {0} key değerli nesnenin toplam satır sayısı {1}", cItemTable.Key, table.Rows.Count));
            }

            // Belirli key bilgilerine ait değerlerin çekilmesi 
            var values = mCache.GetValues(new string[] { "Person", "Products" ,"Aspnet40"}); 

        }
    }
}