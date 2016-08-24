using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<object> list2=new LinkedList<object>();
            List<string> list=new List<string>();
            
            list.Add("slm");
            list.Add("123");
            list.Add("3.25");
            list.Add("true");
            list.Add("**********");
            
            

            foreach (var x in list)
            {
                Console.WriteLine(x);

            }
            Console.ReadKey();
        }
    }
}
