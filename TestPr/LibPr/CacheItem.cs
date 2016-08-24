using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpress.Library.LibPr
{
    internal class CacheItem
    {
        internal IItem Item { get; set; }
        internal DateTime InsertDateTime { get; set; }
        internal DateTime LastAccessTime { get; set; }
    }
}
