using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chain_Of_Responsibilty
{
    class Para20:Banknot
    {

        public override Miktar ParaCek(int _tutar)
        {
            if (_tutar >= 20)
            {
                return new Miktar() { Adet = _tutar / 20, Kalan = _tutar % 20, Tutar = 20 };

            }
            else
            {
                return _banknot.ParaCek(_tutar);
            }
        }
    }
}
