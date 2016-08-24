using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Object_Pool_Pattern
{
    class Program
    {
        public class PooledObject
        {
            DateTime _createdAt = DateTime.Now;

            public DateTime CreatedAt
            {
                get { return _createdAt; }
            }

            public string TempData { get; set; }
        }


        public static class Pool
        {
            private static List<PooledObject> _available = new List<PooledObject>();
            private static List<PooledObject> _inUse = new List<PooledObject>();

            public static PooledObject GetObject()
            {
                lock (_available)
                {
                    if (_available.Count != 0)
                    {
                        PooledObject po = _available[0];
                        _inUse.Add(po);
                        _available.RemoveAt(0);
                        return po;
                    }
                    else
                    {
                        PooledObject po = new PooledObject();
                        _inUse.Add(po);
                        return po;
                    }
                }
            }

            public static void ReleaseObject(PooledObject po)
            {
                CleanUp(po);

                lock (_available)
                {
                    _available.Add(po);
                    _inUse.Remove(po);
                }
            }

            private static void CleanUp(PooledObject po)
            {
                po.TempData = null;
            }
        }


        static void Main(string[] args)
        {
            PooledObject po = Pool.GetObject();
            Console.WriteLine("Creating Time  :"+po.CreatedAt);
            Pool.ReleaseObject(po);
            Console.WriteLine("Now :"+DateTime.Now);
            
            Thread.Sleep(1000);
            Console.WriteLine("*********************");

            Console.WriteLine("Now :"+DateTime.Now);
            po = Pool.GetObject();
            Console.WriteLine("Creating Time :"+po.CreatedAt);
            
            

            Console.ReadLine();
        }
    }
}
