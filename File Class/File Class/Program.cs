using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace File_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            File.WriteAllText("data.txt","şehir çok sıkıcı");

            //byte[] data = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            //File.WriteAllBytes("data.txt",data);
            //IEnumerable<string> s=File.ReadLines("data.txt");
            
            byte[] data=File.ReadAllBytes("data.txt");


            foreach (byte b in data)
            {
                
                Console.WriteLine(b);
            }
            
            Console.WriteLine(Encoding.UTF8.GetString(data));
            Console.ReadLine();
        }
    }
}
