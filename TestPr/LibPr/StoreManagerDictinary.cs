using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpress.Library.LibPr
{
   public class StoreManagerDictinary<T, H> : StoreManager<T, H>
   {
       private Dictionary<T, H> _dictionary;

       public StoreManagerDictinary()
       {
           _dictionary=new Dictionary<T, H>();
       }

        public override void Add(T key, H item)
        {
            _dictionary.Add(key,item);
        }

        public override void Remove(T key)
        {
            _dictionary.Remove(key);
        }

        public override H Get(T key)
        {
           return _dictionary[key];
        }
    }
}
