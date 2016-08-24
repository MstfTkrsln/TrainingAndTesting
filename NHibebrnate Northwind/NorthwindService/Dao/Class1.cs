using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dao
{
    public interface IDao<T>
    {
        void Save(T item);
        void Update(T item);
        void Delete(T item);
    }
}
