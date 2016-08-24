using System;
using System.Collections.Generic;
using System.Text;
using Pluggable.Interfaces;
using Pluggable.Attributes;

namespace PluggableComponent1
{
    [CalculationPlugInAttribute("This plug-in will add two numbers together")]
    class Adder: ICalculator
    {
        #region ICalculator Members

        public int Calculate(int a, int b)
        {
            return a + b;
        }

        public char GetSymbol()
        {
            return '+';
        }

        #endregion
    }
}
