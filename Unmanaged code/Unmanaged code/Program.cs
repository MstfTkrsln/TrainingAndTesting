using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unmanaged_code
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            unsafe
            {
                int* ptr1, ptr2;
                ptr1 = &x;
                ptr2 = ptr1;
                *ptr2 = 20;
                Console.WriteLine(" x : {0}\t *x  : {1} ",x,(int) &x);
                Console.WriteLine();
            }


            unsafe
            {
                int a = 100;
                int* ptr3;
                ptr3 = &a;
                Console.WriteLine("&a         :"+(int)&a);
                Console.WriteLine("ptr3       :"+(int)ptr3);
                Console.WriteLine("pt3 Adresi :"+(int) &ptr3);
            }

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
