using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Drectory_and_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Şu anki Klasör :{0}",Directory.GetCurrentDirectory());
            Console.WriteLine();

            Console.WriteLine(@"C:\ Klaörleri");
            Console.WriteLine();

            string[] klasorler = Directory.GetDirectories(@"c:\");

            foreach (string k in klasorler)
            {
                Console.WriteLine(k);

                DirectoryInfo di=new DirectoryInfo(k);

                Console.WriteLine(di.Exists);
                Console.WriteLine(di.CreationTime);
                Console.WriteLine(di.LastWriteTime);
                Console.WriteLine(di.FullName);
                Console.WriteLine(di.Parent);
                Console.WriteLine(di.Root);
               
            }



            Console.ReadLine();
        }
    }
}
