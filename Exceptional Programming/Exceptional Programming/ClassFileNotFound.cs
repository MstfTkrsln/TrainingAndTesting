using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Exceptional_Programming
{
    class ClassFileNotFound
    {
        public ClassFileNotFound()
        {
            File.Open(@"c:\\olmayanklasör\olmayandosya.txt", FileMode.Open);
        }
    }
}
