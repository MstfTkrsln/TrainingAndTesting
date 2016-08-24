using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Bitmap bmp =(Bitmap) Bitmap.FromFile(@"C:\Users\Public\Pictures\Sample Pictures\Koala.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox1.Image = bmp;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            unsafe
            {
                Bitmap oldBmp = (Bitmap) pictureBox1.Image;
                Bitmap bmp = new Bitmap(oldBmp.Width, oldBmp.Height, PixelFormat.Format24bppRgb);

                BitmapData oldBmpData = oldBmp.LockBits(new Rectangle(0, 0, oldBmp.Width, oldBmp.Height),ImageLockMode.ReadOnly, oldBmp.PixelFormat);

                IntPtr ptrOld = oldBmpData.Scan0;

                BitmapData newBmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite,bmp.PixelFormat);

                IntPtr ptrNew = newBmpData.Scan0;

                byte* pointerOld = (byte*)ptrOld;
                byte* pointerNew = (byte*)ptrNew;

                for (int y = 0; y < oldBmp.Height; ++y)
                    for (int x = 0; x < oldBmp.Width; ++x)
                    {
                        

                        int temp = y*oldBmpData.Stride + x*3;//pixel sırasını buluyor. kaç satır varsa çarp ve o satırdaki sırasıyla topla

                        byte * oldpointerxy= pointerOld + temp; //başlangıç pointer ile temp topla pixeli bul
                        byte* newpointerxy = pointerNew + temp; //başlangıç pointer ile temp topla pixeli bul

                        *newpointerxy = *oldpointerxy;
                        *(newpointerxy+1) = *(oldpointerxy);
                        *(newpointerxy+2) = *(oldpointerxy);

                    }

                oldBmp.UnlockBits(oldBmpData);
                bmp.UnlockBits(newBmpData);

                if (pictureBox1.Image != null)
                {
                    // Bitmap oldBmp = (Bitmap)pictureBox1.Image;
              
                    oldBmp.Dispose();
                }

                pictureBox1.Image = bmp;
                MessageBox.Show("bitti");
            }


        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            int[] dizi = {10, 20, 30, 40};
            unsafe
            {
                fixed (int* p = &dizi[0])
                {
                    byte* b = (byte*) p;

                    MessageBox.Show(((ulong) b).ToString());
                    MessageBox.Show(((ulong)(b+1)).ToString());


                    MessageBox.Show((*b).ToString());//10
                    MessageBox.Show((*(b+1)).ToString());//0
                    MessageBox.Show((*(b+2)).ToString());
                    MessageBox.Show((*(b+3)).ToString());

                    MessageBox.Show((*(b + 4)).ToString());//20
                    MessageBox.Show((*(b + 5)).ToString());//0
                    MessageBox.Show((*(b + 6)).ToString());
                    MessageBox.Show((*(b + 7)).ToString());
                }
            }

        }
    }
}
