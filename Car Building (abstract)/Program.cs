using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            AbsractBuilderAraba araba=new BmwBuilder();
            araba.Create();
            Console.ReadLine();
            
        }


       }
}
