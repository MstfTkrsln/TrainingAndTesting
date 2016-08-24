using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exceptional_Programming
{
    class ClassArrayTypeMismatch
    {
        public ClassArrayTypeMismatch()
        {
            string[] array1 = { "cat", "dog", "fish" };
            object[] array2 = array1;
            array2[0] = 5;
        }
    }
}
