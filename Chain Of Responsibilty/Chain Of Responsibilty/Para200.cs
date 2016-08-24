using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chain_Of_Responsibilty
{
    class Para200:Banknot
    {

        public override Miktar ParaCek(int _tutar)
        {
            if (_tutar>=200)
            {
                return new Miktar() { Adet = _tutar / 200, Kalan = _tutar % 200, Tutar = 200 };

            }
            else
            {
                return _banknot.ParaCek(_tutar);
            }
        }
        
    }
}
