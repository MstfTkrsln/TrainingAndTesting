using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class__Shadowing_
{
        class A
        {
            public void Name()
            {
                Console.WriteLine("Class A");
            }

            public virtual void Name2() 
            {
                Console.WriteLine("A");
            }
        }

        class B:A
        {
            public new void Name() //shadowing
            {
                Console.WriteLine("Class B");
            }

            public override void Name2()
            {
                Console.WriteLine("B");
            }
        }
}
