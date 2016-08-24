using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chain_Of_Responsibilty
{
    class Para50:Banknot
    {
        public override Miktar ParaCek(int _tutar)
        {
            if (_tutar >= 50)
            {
                return new Miktar() { Adet = _tutar / 50, Kalan = _tutar % 50, Tutar = 50 };

            }
            else
            {
                return _banknot.ParaCek(_tutar);
            }
        }
    }
}
