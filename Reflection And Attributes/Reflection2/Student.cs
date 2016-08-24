using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reflection2
{
    class Student
    {   
        public string Name;
        public string Bolum;
        
    }

    class StudentAttribute
    {
        [ZorunluAlan]
        public string Name;
        [ZorunluAlan]
        public string Bolum;
    }
}
