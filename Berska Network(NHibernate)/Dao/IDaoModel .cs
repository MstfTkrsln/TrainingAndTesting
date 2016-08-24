using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dao
{
    public interface IDaoModel<T>
    {
        void Save(T item);
        
    }
}
