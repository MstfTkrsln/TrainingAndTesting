using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Gnip.Powertrack;

namespace TalkwalkerStreamTest
{
    class Program
    {
        static void Main(string[] args)
        {
           // var dt = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(Math.Round(1456928377000 / 1000d)).ToLocalTime();
            
            TalkwalkerStreamReader tester = new TalkwalkerStreamReader();

            tester.Connect("interpressstream2");

            while (true)
            {
                Thread.Sleep(5000);
            }

        }
    }
}
