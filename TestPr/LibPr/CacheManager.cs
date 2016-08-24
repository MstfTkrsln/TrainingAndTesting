using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpress.Library.LibPr
{
   public class CacheManager<T> where T:IItem
   {
       private StoreManager<long, T> storeManager;

       public CacheManager(StoreManager<long,T> _manager )
       {
           storeManager = _manager;
       }

       public CacheManager()
       {
           storeManager=new StoreManagerDictinary<long, T>();
       }

       public virtual void Add(T item)
       {
           storeManager.Add(item.Key,item);
       }

       public virtual void Remove(T item) 
       {
           storeManager.Remove(item.Key);
       }

       public virtual T Get(long key)
       {
          return  storeManager.Get(key);
       }
    }
}
