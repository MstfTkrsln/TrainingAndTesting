using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList
            ArrayList arrayKayitlar=new ArrayList();

            arrayKayitlar.Add("Ram");
            arrayKayitlar.Add("Monitor");
            arrayKayitlar.Add("CPU");
            arrayKayitlar.Add("Mouse");
            arrayKayitlar.Add("Klavye");
            arrayKayitlar.Add("Capture");
            
            for (int i = 0; i < arrayKayitlar.Count; i++)
            {
                Console.WriteLine(arrayKayitlar[i]);
            }
            
            Console.WriteLine("*******************");
            

            int sonuc = arrayKayitlar.BinarySearch("CPU",new CaseInsensitiveComparer());

            if (0 < sonuc)
                {
                    Console.WriteLine("Kayıt bulundu ve Silinecek :" + arrayKayitlar[sonuc]);
                }
            else
                {
                    Console.WriteLine("Kayıt Bulanamadı...");
                }
            arrayKayitlar.Remove("CPU");
            arrayKayitlar.Sort();
            Console.WriteLine("********Sıralandı*******");
            for (int i = 0; i < arrayKayitlar.Count; i++)
            {
                Console.WriteLine(arrayKayitlar[i]);
            }
            #endregion

            Console.Clear();

            #region HashTable
            

            Hashtable hashKayitlar=new Hashtable();
            
            hashKayitlar.Add("A","Ankara");
            hashKayitlar.Add("B","Bursa");
            hashKayitlar.Add("D","Denizli");
            

            if (hashKayitlar.ContainsKey("B"))
            {
                Console.WriteLine(hashKayitlar["B"]);

            }
            #endregion

            Console.Clear();

            #region SortedList
            SortedList sortedKayitlar=new SortedList();

            sortedKayitlar.Add(3,"Üçüncü");
            sortedKayitlar[2] = "ikinci";
            sortedKayitlar.Add(4,"Beşinci");

            sortedKayitlar[4]="Dördüncü";//değiştirdik.

            //for ile dönülebilir indisi vardır
            for (int i = 0; i < sortedKayitlar.Count; i++)
            {
                Console.WriteLine(sortedKayitlar.GetByIndex(i));

            }
            #endregion

            Console.Clear();

            //başka bir thread işlem yapmaz bekler.
            lock (sortedKayitlar.SyncRoot)
            {
                foreach (var item in sortedKayitlar.Values)
                {
                    Console.WriteLine(item);
                }
                
            }
            Console.ReadKey();
        }
    }
}
