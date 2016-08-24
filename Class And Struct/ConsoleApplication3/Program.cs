using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApplication3
{
    class struct_classs
    {

        class cls
        {
            public int x;

            public cls(int x_Int)
            {
                x = x_Int;
            }
        }

        struct stc
        {
            public int x;

            public stc(int x_Int)
            {
                x = x_Int;
                
            }
  }      

        private static void Main(string[] args)
        {


            cls r1 = new cls(10);
            cls r2 = new cls(20);

            stc s1 = new stc(10);
            stc s2 = new stc(20);

            Console.WriteLine("r1.x:{0}, r2.x:{1}, s1.x:{2}, s2.x:{3}", r1.x, r2.x, s1.x, s2.x);


            r1 = r2;
            s1 = s2;

            Console.WriteLine("r1=r2, s1=s2");
            Console.WriteLine("r1.x:{0}, r2.x:{1}, s1.x:{2}, s2.x:{3}", r1.x, r2.x, s1.x, s2.x);


            r2.x = 100;
            s1.x = 200;

            Console.WriteLine("r1=r2, s1=s2");
            Console.WriteLine("r1.x:{0}, r2.x:{1}, s1.x:{2}, s2.x:{3}", r1.x, r2.x, s1.x, s2.x);

            Console.ReadKey();
        }
    }
}