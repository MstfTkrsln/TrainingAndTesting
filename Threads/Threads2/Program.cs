using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threads2
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            Thread thread=new Thread(new ThreadStart(Test));

            Thread thread2=new Thread(new ParameterizedThreadStart(Test2));

            thread.Start();

            thread2.Start(100);

            Console.ReadLine();

        }


        public static void Test()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write(i);
            }
        }

        public static void Test2(object p)
        {
            for (int i = 0; i <(int) p; i++)
            {
                Console.Write("X");
            }
        }
    }
}
