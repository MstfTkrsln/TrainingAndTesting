using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Xml.XPath;

namespace Singleton_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            
            Console.WriteLine("S1 ID  : "+s1.Id);
            Console.WriteLine();

            Singleton s2 = Singleton.GetInstance();

            Console.WriteLine("S2 ID  : " + s2.Id);
            Console.WriteLine();

            Singleton s3 = Singleton.GetInstance();

            Console.WriteLine("S3 ID  : " + s3.Id);

            Console.ReadLine();
            
        }
    }
}
