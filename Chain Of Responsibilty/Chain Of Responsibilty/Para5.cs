using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chain_Of_Responsibilty
{
    class Para5:Banknot
    
    {
        public override Miktar ParaCek(int _tutar)
        {
            if (_tutar >= 5)
            {
                return new Miktar() { Adet = _tutar / 5, Kalan = _tutar % 5, Tutar = 5 };

            }
            else
            {
                return _banknot.ParaCek(_tutar);
            }
        }
    }

}
