using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq_Wpf
{
    class Uyeler
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tc { get; set; }
        public DateTime Dt { get; set; }
        public Uyeler(string ad, string soyad, string tc, DateTime dt)
        {
            Ad = ad;
            Soyad = soyad;
            Tc = tc;
            Dt = dt;
        }
    }
}
