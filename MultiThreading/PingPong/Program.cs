using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PingPong
{
    class Program
    {
        class MyThread
        {
            public Thread thread;
            private PingPong pingPongObject;


            public MyThread(string name,PingPong pp)
            {
                thread =new Thread(Run);
                pingPongObject = pp;
                thread.Name = name;
                thread.Start();
            }

            void Run()
            {
                if (thread.Name=="Ping")
                {
                    for (int i = 0; i < 5; i++)
                    {
                        pingPongObject.ping(true);
                    }
                    pingPongObject.ping(false);
                }
                else
                {
                    for (int i = 0; i < 5; i++)
                    {
                        pingPongObject.pong(true);
                    }
                    pingPongObject.pong(false);
                }
            }
        }


        class PingPong
        {
            public void ping(bool running)
            {
                lock (this)
                {
                    if (!running)
                    {
                        Monitor.Pulse(this);
                        return;
                     }

                    Console.Write("Ping ");
                    Monitor.Pulse(this);//pong un çalışmasına izin ver
                    Monitor.Wait(this);//pong un tamamlanmasını bekle
                }
            }
            public void pong(bool running)
            {
                lock (this)
                {
                    if (!running)
                    {
                        Monitor.Pulse(this);
                       return;
                    }

                    Console.WriteLine("Pong ");
                    Monitor.Pulse(this);
                    Monitor.Wait(this);
                }
            }
        }

        static void Main(string[] args)
        {
            PingPong pp=new PingPong();

            Console.WriteLine("***PinPon Topu Zıpladı***");

            MyThread th1=new MyThread("Ping",pp);
            MyThread th2=new MyThread("Pong",pp);


            th1.thread.Join();
            th2.thread.Join();

            Console.WriteLine("***Pinpon Topu Durdu***");
            Console.ReadLine();
        }
    }
}
