using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    class Program
    {

         public class hesap
        {
            protected  int index;
            public int kareal(int a)
            {
                return a*a;
            }
            
            private int kupal(int a)
            {
                
                return a*a*a;
                
            }


        }
        static void Main(string[] args)
        {
            hesap hsp=new hesap();
            int snc=hsp.kareal(5);
            
            
            Console.WriteLine(snc);
            Console.ReadKey();

            mathclass mc= new mathclass();
            double snc2=mc.karekok(9);
            Console.WriteLine(snc2);
            Console.ReadKey();
            
        }
    }
}
