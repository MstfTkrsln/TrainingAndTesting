using System;
using System.Collections.Generic;
using System.Text;
using Pluggable.Interfaces;
using Pluggable.Calculators;

namespace Pluggable
{
    public class CalculatorHost
    {
        public CalculatorHost(ICalculator calculator)
        {
            m_calculator = calculator;
        }

        public CalculatorHost() : this(new Divider())
        {
            
        }

        private int m_x, m_y;
        private ICalculator m_calculator;

        public int X
        {
            get { return m_x; }
            set { m_x = value; }
        }

        public int Y
        {
            get { return m_y; }
            set { m_y = value; }
        }

        public char Operator
        {
            get { return m_calculator.GetSymbol(); }
        }

        public int Calculate()
        {
            return m_calculator.Calculate(m_x, m_y);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} = {3}",
                m_x.ToString(),
                m_calculator.GetSymbol(),
                m_y.ToString(),
                m_calculator.Calculate(m_x, m_y));
        }
    }
}
