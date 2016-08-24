using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace ConsoleApplication14
{

     class mathclass
    {
        private double karekok(int a)
        {
            return Math.Sqrt(a);
        }

         public int carp(int a)
         {

             return a*a;
         }
        
     }

    class mathclass2
    {
        public int topla(int b)
        {
            mathclass mc=new mathclass();
            
            return b + b;
        }

    }
}
