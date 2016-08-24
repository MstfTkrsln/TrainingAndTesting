using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enum_Example
{
    class Program
    {

        enum product
        {
            tv=1,
            buzdolabi,
            telefon,
            laptop,
            ütü,
            
            


        }

        
        static void Main(string[] args)
        {
            string[] urunler = Enum.GetNames(typeof (product));
            foreach (string str in urunler)
            {
                Console.WriteLine(str);
                
                
            }
           Console.ReadLine();
        }
        
    }
}
