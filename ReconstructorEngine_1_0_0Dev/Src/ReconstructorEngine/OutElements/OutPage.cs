using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpress.Library.ReconstructorEngine.OutElements
{
   public class OutPage
    {
       public IList<OutImage>  Images { get; set; }

       public OutPage()
       {
           Images=new List<OutImage>();
       }
    }
}
