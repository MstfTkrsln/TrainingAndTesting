using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pluggable.Attributes;
using Pluggable.Interfaces;

namespace PluggableComponent3
{
        [CalculationPlugIn("This plug-in will extaction two numbers together")]
    public class Extraction:ICalculator
    {
        public int Calculate(int a, int b)
        {
            return a - b;
        }

        public char GetSymbol()
        {
            return '-';

        }
    }
}
