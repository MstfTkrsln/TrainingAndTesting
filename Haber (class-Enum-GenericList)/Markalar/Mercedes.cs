using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Markalar
{
    public class Mercedes:Icarable
    {
        public string Model { get; set; }
        public string ModelYear { get; set; }
        public int Hp { get; set; }
        public bool Quatre { get; set; }
        public override string ToString()
        {
            return "Mercedes";
        }
    }
}
