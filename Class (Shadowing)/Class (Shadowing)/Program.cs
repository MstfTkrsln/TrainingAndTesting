using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class__Shadowing_
{
    class Program
    {
        static void Main(string[] args)
        {
            A clsA=new A();
            clsA.Name();
            clsA.Name2();


            B clsB=new B();
            clsB.Name();
            clsB.Name2();

            Console.ReadLine();
        }
    }
}
