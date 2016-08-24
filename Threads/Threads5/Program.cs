using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threads5
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread thr1 = new Thread(new ThreadStart(TestMethod)) { Name = "T1" };
            Thread thr2 = new Thread(new ThreadStart(TestMethod)) { Name = "T2" };
            Thread thr3 = new Thread(new ThreadStart(TestMethod)) { Name = "T3" };

            thr1.Start();
            thr2.Start();
            thr3.Start();


            Console.WriteLine("Finish");
            Console.ReadLine();

        }

        static object test = new object();
        static void TestMethod()
        {

            

            lock (test)
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(500);
                    Console.Write("{0} : {1}  ", Thread.CurrentThread.Name, i);
                }

                Console.WriteLine();
            }


        }
    }
}
