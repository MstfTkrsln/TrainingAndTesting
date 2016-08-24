using System;
using System.Collections.Generic;
using System.Text;

namespace Pluggable.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CalculationPlugInAttribute : Attribute
    {
        public CalculationPlugInAttribute(string description)
        {
            m_description = description;
        }

        private string m_description;

        public string Description
        {
            get { return m_description; }
            set { m_description = value; }
        }
    }
}
