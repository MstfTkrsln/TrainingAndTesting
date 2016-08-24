using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton_Pattern
{
    class Singleton
    {
        private static Singleton _instance=null;
        private static Guid _id;

        private static object _lockObject=new object(); //Multithread kontrolü için

        private Singleton(Guid id)
        {
            _id = id;
        }

        public Guid Id
        {
            get { return _id; }
        }

        public static Singleton GetInstance()
        {
            if (_instance==null)
            {
                lock (_lockObject) //Başka bir thread o an ulaşamaması için lock edeilim.
                {
                    if (_instance==null)
                        _instance=new Singleton(Guid.NewGuid());
                    
                }

             }
            return _instance;
            
            
        }
    }
}
