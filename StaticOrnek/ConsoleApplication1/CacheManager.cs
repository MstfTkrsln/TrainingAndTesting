using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class CacheManager
    {
        private static CacheManager manager;
        List<int> itemsInts=new List<int>();
        protected CacheManager()
        {
            
        }

        public static CacheManager Instance()
        {
            if (manager == null)
            {
                if (ConfigurationSettings.AppSettings["cache"] == "default")
                    manager = new CacheManager();
                if (ConfigurationSettings.AppSettings["cache"] == "fast")
                    manager = new MyCacheManager();
            }
            return manager;
        }

        internal virtual void Add(int p)
        {
          itemsInts.Add(p);
        }
    }

    class MyCacheManager : CacheManager
    {
        SortedList<int,int> itemsList=new SortedList<int, int>();
        internal override void Add(int p)
        {
            itemsList.Add(p,p);
        }
    }
}
