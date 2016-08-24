using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chain_Of_Responsibilty
{
    abstract class Banknot
    {
        protected Banknot _banknot;

        public void Sonraki(Banknot hesap)
        {
            this._banknot = hesap;
        }

        public abstract Miktar ParaCek(int Tutar);
    }
}
