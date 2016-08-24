using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionCreating
{
    class ClassString
    {
        public ClassString(string s)
        {
            if (s==null)
            {
                throw new stringException("String Null Geldi..!");

            }
        }

        public class stringException: Exception
        {
            public stringException(string message) : base(message)
        {
            
        }

        }

    }
}
