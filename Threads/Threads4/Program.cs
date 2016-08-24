using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threads4
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thr1 = new Thread(new ThreadStart(TestMethod)) { Name = "Thread 1" };
            Thread thr2 = new Thread(new ThreadStart(TestMethod)) { Name = "Thread 2" };
            thr1.Priority = ThreadPriority.Highest;
            thr2.Priority = ThreadPriority.Lowest;

            thr1.Start();


            thr2.Start();

            thr1.Join(); thr2.Join();
            Console.WriteLine("Finish");




            Console.ReadLine();

        }
        static int i = 0;
        static void TestMethod()
        {


            for (; i < 100; i++)
            {

                Console.WriteLine(Thread.CurrentThread.Name + " = " + i);

            }

        }
    }
}
