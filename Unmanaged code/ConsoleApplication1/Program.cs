using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static class MyClass
        {
            internal static int a;
            static MyClass()
            {
                Console.WriteLine(a);
            }

            static void test()
            {
                
            }


        }

        internal int a=123;
        static void Main(string[] args)
        {
            MyClass.a = 10;
            MyClass.a = 11;
            Console.ReadLine();
        }
    }
}
