using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    
    class Program
    {


        static void Test()
        {
           
        }
       
        static void Main(string[] args)
        {
           

            CacheManager.Instance().Add(5);
            CacheManager.Instance().Add(10);


        }
    }
}
