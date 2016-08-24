using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class Program
    {
        public class Point
        {
            public int X;
            public int Y;
            public Point(int xPos, int yPos)
            {
                X = xPos;
                Y = yPos;
            }
            public override string ToString()
            {
               
                return string.Format("[{0}, {1}]", this.X, this.Y);
                
            }

            //+ operatörü overload edildi
            //artık + ile 2 point nesnesinin X,Y değerleri toplanıp
            //yeni bir Point nesnesi döndürüyor
            public static Point operator +(Point p1, Point p2)
            {
                Console.Write("[{0} + {1}]  =", p1.ToString(), p2.ToString());
                return new Point(p1.X + p2.Y, p1.Y + p2.X);
            }

            //+ operatörü overload edildi
            //artık + ile 2 point nesnesinin X,Y değerleri çıkarılıp
            //yeni bir Point nesnesi döndürüyor
            public static Point operator -(Point p1, Point p2)
            {
                Console.Write("[{0} - {1}]  =", p1.ToString(),p2.ToString());
                return new Point(p1.X - p2.X, p1.Y - p2.Y);
            }

            public static Point operator *(Point p1, Point p2)
            {
                Console.Write("[{0} * {1}]  =", p1.ToString(),p2.ToString());
                return new Point(p1.X * p2.X,p1.X * p2.Y);
            }
        }

        static void Main(string[] args)
        {
            Point p1 = new Point(10, 3);
            Point p2 = new Point(7, 4);

            //p1+p2 toplamak istiyoruz
            Point p3 = p1 + p2;
            Console.WriteLine(p3);

            Point p4 = p1 - p2;
            Console.WriteLine(p4);

            Point p5 = p1 * p2;
            Console.WriteLine(p5);
            Console.ReadLine();
        }
    }
}
