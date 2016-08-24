using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_Interface
{
    class Urun
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public double Fiyat { get; set; }

        public Urun(int id,string ad,double fiyat)
        {
            Id = id;
            Ad = ad;
            Fiyat = fiyat;
        }
    }
}
