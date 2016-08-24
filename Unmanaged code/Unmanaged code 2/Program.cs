using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unmanaged_code_2
{
    class Program
    {
        
        unsafe static void Main(string[] args)
        {
            
            uint u=2;
            byte b=4;
            double d = 10.5;

            uint* pU = &u;
            byte* pB = &b;
            double* pD = &d;

            Console.WriteLine("Aritmetik İşlemden Önce");
            Console.WriteLine("pU Değeri :"+(uint) &pU);
            Console.WriteLine("pB Değeri :" + (uint)pB);
            Console.WriteLine("pD Değeri :" + (uint)pD);

            pU += 3; //3*4  12 byte ileri
            pB -= 4; //4*1  4 byte geri
            pD++; //8 byte ileri

            Console.WriteLine("\n**************************\n");

             Console.WriteLine("Aritmetik İşlemden Sonra");
             Console.WriteLine("pU Değeri :"+(uint) &pU);
            Console.WriteLine("pB Değeri :" + (uint)pB);
            Console.WriteLine("pD Değeri :" + (uint)pD);

            

            Console.ReadLine();
        }
       
    }
}
