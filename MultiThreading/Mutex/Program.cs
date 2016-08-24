using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Mutex
{
    class Program
    {
        static System.Threading.Mutex mtx=new System.Threading.Mutex();
        
        
        static void Main(string[] args)
        {
            
            Thread T1=new Thread(Method);
            T1.Name = "T1";
            Thread T2=new Thread(Method);
            T2.Name = "T2";

            T1.Start();
            T2.Start();
            
            
            
            Console.ReadLine();
        }

         static void Method()
        {
           mtx.WaitOne();//Bu arada çalışan thread bitmeden başka thread başlayamaz.


            //lock ()   //lock ile aynı işi yapar
            //{
                
           for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(500);
                Console.Write("{0} : {1}\t ",Thread.CurrentThread.Name,i);
            }
            Console.WriteLine();
            mtx.ReleaseMutex();//MUTEX END
            
             
             //}
        }

    }
}

