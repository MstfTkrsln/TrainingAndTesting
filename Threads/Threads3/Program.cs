using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Threads3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ana Thread'ler Başladı...");

            SampleThread thr1=new SampleThread("Thread 1");
            SampleThread thr2 = new SampleThread("Thread 2");
            SampleThread thr3 = new SampleThread("Thread 3");
            thr1.thr.
            do
            {
                Console.WriteLine("--Alt Threadler Aktif--");
                Thread.Sleep(200);
                
                
            } while (thr1.thr.IsAlive && thr2.thr.IsAlive && thr3.thr.IsAlive);

            Console.WriteLine("Ana Thread Sona Erdi.");
            Console.ReadLine();
        }

        
    }


    class SampleThread
    {
        public Thread thr;

        public SampleThread(string threadName)
        {
            thr=new Thread(new ThreadStart(TestMethod));
            thr.Name = threadName;
            thr.Start();

        }


        void TestMethod()
        {
            Console.WriteLine(Thread.CurrentThread.Name+" başladı.");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name+" : " +i);
                Thread.Sleep(300);
                
            }

            Console.WriteLine(Thread.CurrentThread.Name + " sona erdi.");
        }
    }
}
