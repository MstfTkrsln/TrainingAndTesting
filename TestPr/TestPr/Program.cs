using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interpress.Library.LibPr;
using Interpress.WinClient.TestPr;

namespace TestPr
{
    class Program
    {
        class City : IItem
        {

            public long Key { get; set; }
            public string Name { get; set; }
        }

        static void Main(string[] args)
        {
            CacheManager<City> citiesCacheManager =
                new CacheManager<City>(new StoreManagerDictinary<long, City>());
            City istanbul = new City() {Key = 34, Name = "İstanbul"};
            
            City ankara = new City() {Key = 6, Name = "Ankara"};
            citiesCacheManager.Add(istanbul);
            citiesCacheManager.Add(ankara);

            var itemFromCache = citiesCacheManager.Get(34);
            Console.WriteLine(itemFromCache.Name);

            itemFromCache = citiesCacheManager.Get(6);
            Console.WriteLine(itemFromCache.Name);
            Console.Read();
        }
    }
}
