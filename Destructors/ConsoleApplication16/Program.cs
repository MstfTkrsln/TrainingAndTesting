using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Drawing;

namespace ConsoleApplication16
{
    class Program
    {
        class First
        {
            public First()
            {
                Console.WriteLine("First's destructor is called.");
            }

            ~First()
            {
                
            }
        }

        class Second
        {

            ~Second()
            {
                System.Diagnostics.Trace.WriteLine("Second's destructor is called.");
            }
        }

        class Third : Second
        {
            ~Third()
            {
                System.Diagnostics.Trace.WriteLine("Third's destructor is called.");
            }
        }

        class TestDestructors
        {
            static void Main()
            {
                Third t = new Third();
                First f=new First();
                
                Console.ReadLine();

            }

        }
    }
}
