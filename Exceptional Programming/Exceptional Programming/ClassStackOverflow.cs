using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exceptional_Programming
{
    class ClassStackOverflow
    {
        public ClassStackOverflow()
        {
            throw new OverflowException("Stack Doldu");
        }
    }
}
