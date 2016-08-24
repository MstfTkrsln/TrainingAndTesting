using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");

            ExampleThread thread1 = new ExampleThread("thread1");
            ExampleThread thread2 = new ExampleThread("thread2");
            ExampleThread thread3 = new ExampleThread("thread3");

            do
            {
            Console.WriteLine( "< Threads Active >");

            Thread.Sleep(200);
            } while (thread1.thr.IsAlive && thread2.thr.IsAlive && thread3.thr.IsAlive);
            
            Console.WriteLine("Main Thread Finished");
            Console.ReadLine();
        }

        class ExampleThread
        {
            public Thread thr;

            public ExampleThread(string threadname)
            {
                thr=new Thread(new ThreadStart(ExampleMethod));
                thr.Name = threadname;
                thr.Start();
            } 
        }

        static void ExampleMethod()
        {
            Console.WriteLine(Thread.CurrentThread.Name + "is Running");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name+ ": "+i);
                Thread.Sleep(300);
            }

            Console.WriteLine(Thread.CurrentThread.Name +" Finished");
        }
    }
}
