using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Image_Processor
{
    class Processor
    {
        private Image _img;
        private Bitmap bmp;

         public Image Img
        {
            get { return _img; }
            set { _img = value; bmp=new Bitmap(_img);}
        }

        public Processor()
        {
            
        }

        public Processor(Image image)
        {
            Img = image;
        }

        public Image DoGray()
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    //int rgb = ((bmp.GetPixel(i, j).R + bmp.GetPixel(i, j).G + bmp.GetPixel(i, j).B)) / 3; //rgb ortalaması alınıp siyah-beyaz yapılır.
                    //hız için bunu kullanalım.

                    int rgb = bmp.GetPixel(i, j).G;

                    bmp.SetPixel(i, j, Color.FromArgb(rgb, rgb, rgb));
                }
            }
            return bmp;
        }

        public Image DoNegative()
        {
                   
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    bmp.SetPixel(i, j, Color.FromArgb(255 - bmp.GetPixel(i, j).R, 255 - bmp.GetPixel(i, j).G, 255 - bmp.GetPixel(i, j).B));
                }
            }
            return bmp;
        

        }

        internal Image DoRotate()
        {
            
            Bitmap b = new Bitmap(bmp.Height, bmp.Width);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    b.SetPixel(b.Width - j - 1, i, bmp.GetPixel(i, j));
                }
            }
            
            return b;

        }

        internal Image DoRotate2()
        {
            Bitmap b = new Bitmap(bmp.Height, bmp.Width);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    b.SetPixel(j, b.Height - 1 - i, bmp.GetPixel(i, j));
                }
            }
            return b;
        }

        internal Image Resize(int x, int y)
        {
            return _img.GetThumbnailImage(x, y, null, new IntPtr(10000000));
        }
    }
}
