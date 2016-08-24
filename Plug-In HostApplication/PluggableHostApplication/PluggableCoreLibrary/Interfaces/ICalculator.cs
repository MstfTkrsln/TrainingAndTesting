using System;
using System.Collections.Generic;
using System.Text;

namespace Pluggable.Interfaces
{
    public interface ICalculator
    {
        int Calculate(int a, int b);
        char GetSymbol();
    }
}
