using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Struct
{
    struct A
    {
        public int a;

        public struct A1
        {
            public int a1;

            public struct A11
            {
                public int a11;
            }
        }
    }
    
}
