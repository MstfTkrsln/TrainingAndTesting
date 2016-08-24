using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exceptional_Programming
{
    class ClassArgument
    {
        public ClassArgument(int  num)
        {
            // If num is an odd number, throw an ArgumentException. 
            if ((num & 1) == 1)
                throw new ArgumentException("Number must be even", "num");
            
        }
       
    }
}
