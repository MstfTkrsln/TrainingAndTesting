using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Interpress.Library.Libraries.DbtLibrary.Imaging;
using Interpress.Library.ReconstructorEngine.InElements;

namespace Interpress.Library.ReconstructorEngine
{
      class Utils
    {
        static internal int ConvertMMtoPixel(float mm, float dpi)
        {
            return Convert.ToInt32((mm / 25.4F) * dpi);
        }
        static internal int ConvertMMtoPixel(int mm, float dpi)
        {
            return Convert.ToInt32((mm / 25.4F) * dpi);
        }
        static internal int ConvertPixeltoMM(int pixel, float dpi)
        {
            return Convert.ToInt32((pixel / dpi) * 25.4F);
        }

        static internal float ConvertPixeltoMMF(float pixel, float dpi)
        {
            return Convert.ToSingle((pixel / dpi) * 25.4F);
        }

        static internal int ConvertPixeltoMM(float pixel, float dpi)
        {
            return Convert.ToInt32((pixel / dpi) * 25.4F);
        }


         
    }
}
