using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Interpress.Library.ReconstructorEngine.InElements
{
    public class Zone
    {
        public int Number { get; set; }
        public Region Reg { get; set; }
        public ZoneType Type { get; set; }

        public IList<Character>  Chars { get; set; }

        public Zone()
        {
            Chars=new List<Character>();
        }
    }

    public enum ZoneType
    {
        Image,
        Header,
        Title,
        Text,
        Table,
        Spot,
        Footer
    }
}
