using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace Dictionary
{
    class Store<T,H>
    {
        Dictionary<T,H> dic=new Dictionary<T, H>(); 


        internal void Add(T Key, H Item)
        {
            dic.Add(Key,Item);
            
        }

        internal void Remove(T Key)
        {
            dic.Remove(Key);
        }


        internal H Get(T Key)
        {
            return dic[Key];
        }
    }
}
