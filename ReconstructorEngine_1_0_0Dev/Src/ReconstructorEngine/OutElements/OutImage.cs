
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;

namespace Interpress.Library.ReconstructorEngine.OutElements
{
    public class OutImage
    {
        public Bitmap Img { get; set; }
        public Region Reg { get; set; }
        public PointF LocationPixel { get; set; }
       
    }
}
