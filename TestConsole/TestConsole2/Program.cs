using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Interpress.Library.Libraries.InterParser;
using System.Threading.Tasks;

namespace TestConsole2
{
    internal class OneAtATimePlease
    {
        private static CountdownEvent _countdown = new CountdownEvent(3);

        private static void Main()
        {
            new Thread(SaySomething).Start("I am thread 1");
            new Thread(SaySomething).Start("I am thread 2");
            new Thread(SaySomething).Start("I am thread 3");

           // _countdown.Wait(); // Blocks until Signal has been called 3 times
            Console.WriteLine("All threads have finished speaking!");
        }

        private static void SaySomething(object thing)
        {
            Thread.Sleep(TimeSpan.FromMinutes(1));
            Console.WriteLine(thing);
            //_countdown.Signal();
        }
    }
}