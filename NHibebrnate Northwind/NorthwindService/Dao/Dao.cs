using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dao
{
    public class Dao<T>:IDao<T>
    {

        public void Save(T item)
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }

        public void Delete(T item)
        {
            throw new NotImplementedException();
        }
    }
}
