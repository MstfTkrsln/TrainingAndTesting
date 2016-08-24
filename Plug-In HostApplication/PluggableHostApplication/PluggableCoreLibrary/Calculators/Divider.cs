using System;
using System.Collections.Generic;
using System.Text;
using Pluggable.Interfaces;

namespace Pluggable.Calculators
{
    class Divider:ICalculator
    {
        #region ICalculator Members

        public int Calculate(int a, int b)
        {
            return a / b;
        }

        public char GetSymbol()
        {
            return '/';
        }

        #endregion
    }
}
