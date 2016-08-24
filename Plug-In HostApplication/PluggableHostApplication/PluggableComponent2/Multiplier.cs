using System;
using System.Collections.Generic;
using System.Text;
using Pluggable.Attributes;
using Pluggable.Interfaces;

namespace PluggableComponent2
{
    [CalculationPlugInAttribute("This plug-in will multiply two numbers together")]
    public class Multiplier: ICalculator
    {
        #region ICalculator Members

        public int Calculate(int a, int b)
        {
            return a * b;
        }

        public char GetSymbol()
        {
            return '*';
        }
        
        #endregion
    }
}
