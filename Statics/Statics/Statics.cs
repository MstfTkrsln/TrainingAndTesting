using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Statics
{
    internal class Statics
    {
        public static class Sehir
        {
            static Hashtable h=new Hashtable();
            public static SortedDictionary<int, string> sehirler = new SortedDictionary<int, string>();
            
            public static int baskentPlaka = 06;

            static Sehir()
            {
                sehirler.Add(01, "Adana");
                sehirler.Add(34, "Istanbul");
                sehirler.Add(35, "Izmir");
                sehirler.Add(18, "Çankırı");
                sehirler.Add(06, "Ankara");
            }

            public static void Listele(SortedDictionary<int, string> Sd)
            {
                foreach (var item in Sd)
                {
                    Console.WriteLine(item.Key + "  : " + item.Value);
                }
            }

            public static string Baskent(int plaka)
            {
                foreach (var item in sehirler)
                {
                    if (item.Key == plaka)
                    {
                        return "Başkent  : " + item.Value;
                        
                    }
                }
                return "Bulunamadı";
            }
        }
    }
}

