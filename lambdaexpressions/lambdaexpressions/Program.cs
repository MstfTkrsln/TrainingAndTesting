using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lambdaexpressions
{
    class Program
    {
        private delegate int del(int a,int b);
        
        static void Main(string[] args)
        {
            del myDelegate = delegate(int i, int j) { return i*j; };

            int snc = myDelegate(5,10);
         
            //j = 25

        //    del myDel = x => x * x;

        //    int snc = myDel(5, 5);
                 Console.WriteLine(snc);
                 Console.ReadKey();
        }

   
    }
}
