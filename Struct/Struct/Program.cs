using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            A StructA=new A();
            StructA.a = 1;
            
            A.A1 StructA1=new A.A1();
            StructA1.a1 = 2;
                  
            A.A1.A11 StructA11=new A.A1.A11();
            StructA11.a11 = 3;

            Console.WriteLine(StructA.a);
            Console.WriteLine(StructA1.a1);
            Console.WriteLine(StructA11.a11);
            Console.ReadLine();
        }
    }
}
