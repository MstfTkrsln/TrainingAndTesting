using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exceptional_Programming
{
    class ClassInvalidOperation
    {
        public ClassInvalidOperation()
        {
            int[] array = { 0, 0 };
            IEnumerator enumerator = array.GetEnumerator();
            Console.Write("{0}", enumerator.Current);
        }
    }
}
