
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operator_Overloading
{
    class Program
    {
        class Islem
        {
            private int x;
            private int y;

            public Islem()
            {
                
            }

            public Islem(int X,int Y)
            {
                x = X;
                y = Y;
            }

            public void Yazdir()
            {
                Console.WriteLine("X :"+x+"  Y :"+y);
            }


            public static Islem operator +(Islem obj1, Islem obj2)
            {
                Islem objIslem=new Islem();
                objIslem.x = obj1.x + obj2.x;
                objIslem.y = obj1.y + obj2.y;

                Console.WriteLine(" (+) Overload Edildi. ");

                return objIslem;
            }

        }
        static void Main(string[] args)
        {

            Islem o1=new Islem(5,4);
            o1.Yazdir();
            
            Islem o2=new Islem(7,9);
            o2.Yazdir();

            Console.WriteLine();
            Islem o3 = o1 + o2;

            o3.Yazdir();

            Console.ReadLine();
        }
    }
}
