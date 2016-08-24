using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Product__Linq_
{

    public class Product
    {
        
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        
        public Product(string ad,decimal fiyat)
        {
            
            Fiyat = fiyat;
            Ad = ad;
        }
        

        public override string ToString()
        {
            return Ad + "  : " + Fiyat;
        }
    }
}
