using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;

namespace Markalar
{
   public interface Icarable
    {
        string Model { get; set; }
        string ModelYear  { get; set; }
        int Hp { get; set; }
        bool Quatre { get; set; }
      
    }
}
