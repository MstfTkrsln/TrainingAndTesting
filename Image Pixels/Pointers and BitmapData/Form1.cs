using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Pointers_and_BitmapData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
            fd.Title = "Resim Seçiniz";
            fd.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";

            if (fd.ShowDialog() == DialogResult.OK != null)
            {
                picOriginal.ImageLocation = fd.FileName;
            }
        }

       
        private void btnGetPixels_Click(object sender, EventArgs e)
        {
            Bitmap bmp=new Bitmap(picOriginal.Image);
            Rectangle rect=new Rectangle(0,0,bmp.Width,bmp.Height);
            BitmapData bmData = bmp.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            IntPtr startPixel = bmData.Scan0;

            int pixelCount = bmData.Stride * bmp.Height;    //Stride özelliği bitmap nesnesinin tarama genişliğini verir. Daha kaba bir tabirle bir satırın kaç pikselden oluştuğunu

            byte[] rgbPixels=new byte[pixelCount];

            Marshal.Copy(startPixel,rgbPixels,0,pixelCount);//pixelleri diziye aktardık.

            byte black;
            for (int i = 2; i < rgbPixels.Length; i+=3)
            {
                black = (byte)Math.Abs((Byte.Parse(rgbPixels[i - 2].ToString()) + Byte.Parse(rgbPixels[i - 1].ToString()) + Byte.Parse(rgbPixels[i].ToString())) / 3);
                rgbPixels[i - 2] = black;
                rgbPixels[i - 1] = black;
                rgbPixels[i] = black;
            }

            Marshal.Copy(rgbPixels, 0, startPixel, pixelCount);

            bmp.UnlockBits(bmData);

            picNew.Image = bmp;

        }
    }
}
