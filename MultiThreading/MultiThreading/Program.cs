using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Thread th=new Thread(yazdir);
            th.Priority = ThreadPriority.Highest;// öncelik atadık
            th.Start("+");
            
            th.Join(); //th threadinin bitmesini bekler

            for (int i = 0; i < 500; i++)
            {
                Console.Write("- ");
            }

            Console.ReadLine();
        }

        static public void yazdir(object c)
        {
            
            for (int i = 0; i < 500; i++)
            {
                Console.Write("{0} ",c);
            }
           
        }
    }
}
