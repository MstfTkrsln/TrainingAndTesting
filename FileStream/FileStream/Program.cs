using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream File=new Stream();
            byte[] data = new byte[]{101, 102, 103, 104, 105};
            char[] datas = new[] {'m', 'u', 's', 't', 'a', 'f', 'a'};
            
            File.Write(datas);
            Console.WriteLine("***************************");
            File.Read();


            Console.ReadKey();
        }
    }
}
