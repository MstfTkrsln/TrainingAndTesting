using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chain_Of_Responsibilty
{
    class Para10:Banknot
    {
        public override Miktar ParaCek(int _tutar)
        {
            if (_tutar >= 10)
            {
                return new Miktar() { Adet = _tutar / 10, Kalan = _tutar % 10, Tutar = 10 };

            }
            else
            {
                return _banknot.ParaCek(_tutar);
            }
        }
    }
}
