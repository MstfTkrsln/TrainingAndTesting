using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exceptional_Programming
{
    class ClassKeyNotFound
    {
        public ClassKeyNotFound()
        {
            //
            // Create new Dictionary with string key of "one"
            //
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("one", "value");

            //
            // Try to access key of "two"
            //
            string value = test["two"];
        }
    }
}
