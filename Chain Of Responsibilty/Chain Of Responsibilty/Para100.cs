using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chain_Of_Responsibilty
{
    class Para100:Banknot
    {
        public override Miktar ParaCek(int _tutar)
        {
            if (_tutar >= 100)
            {
                return new Miktar() { Adet = _tutar / 100, Kalan = _tutar % 100, Tutar = 100 };

            }
            else
            {
                return _banknot.ParaCek(_tutar);
            }
        }
    }
}
