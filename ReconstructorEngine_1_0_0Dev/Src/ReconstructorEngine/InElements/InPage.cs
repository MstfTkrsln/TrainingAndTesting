using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace Interpress.Library.ReconstructorEngine.InElements
{
    public class InPage:IDisposable
    {
        
        private MemoryStream ms;

        public Bitmap Img { get;  set; }

        public IList<Zone>  Zones { get; set; }

        public int Number { get; set; }


        public InPage(byte[] imageData)
        {
            Zones=new List<Zone>();
            ms=new MemoryStream(imageData);
            Img =(Bitmap) Image.FromStream(ms);

        }
       

        public void Dispose()
        {
            if(ms!=null)
                ms.Dispose();
            if(Img!=null)
                Img.Dispose();

        }

        ~InPage()
        {
         Dispose();   
        }
    }
}
