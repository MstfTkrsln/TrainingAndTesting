using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = string.Empty;

            DateTime start = DateTime.Now;

            for (int i = 0; i < 50000; i++)
            {
                str += i;

            }
            DateTime finish = DateTime.Now;

            double time = (finish - start).TotalSeconds;

            Console.WriteLine("String ile Performans : "+time);

            Console.WriteLine();

            string str2 = string.Empty;
            System.Text.StringBuilder stb=new System.Text.StringBuilder(str2);

            start = DateTime.Now;
            for (int i = 0; i < 50000; i++)
            {
                stb.Append(i);
            }
            finish = DateTime.Now;
            time = (finish - start).TotalSeconds;
            Console.WriteLine("StringBuilder ile Performans : "+time);


            Console.ReadLine();

        }
    }
}
