using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpress.Library.LibPr
{
    public abstract class StoreManager<T,H>
    {
        public abstract void Add(T key, H item);
        public abstract void Remove(T key);
        public abstract H Get(T key);

    }
}
