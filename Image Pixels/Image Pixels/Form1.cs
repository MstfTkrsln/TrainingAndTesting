using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Image_Pixels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[,] pixelArray;
        public int[,] greyPixelArray;

        private void btnOpen_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
            fd.Title = "Resim Seçiniz";
            fd.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";

            if (fd.ShowDialog() == DialogResult.OK != null)
            {
                pictureOriginal.ImageLocation = fd.FileName;
                pictureOriginal.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }


        private void btnGetPixels_Click(object sender, EventArgs e)
        {
            pixelArray = new int[pictureOriginal.Image.Height, pictureOriginal.Image.Width];
            greyPixelArray = new int[pictureOriginal.Image.Height, pictureOriginal.Image.Width];

            BuildPixelArray(pictureOriginal.Image);
        }

        private void BuildPixelArray(Image myImage)
        {
            Rectangle rect = new Rectangle(0, 0, myImage.Width, myImage.Height);
            Bitmap temp = new Bitmap(myImage);

            BitmapData bmData = temp.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int remain = bmData.Stride - bmData.Width * 3;

            unsafe
            {
                byte* ptr = (byte*)bmData.Scan0;

                for (int i = 0; i < bmData.Height; i++)
                {
                    for (int j = 0; j < bmData.Width; j++)
                    {

                        pixelArray[i, j] = ptr[0] + ptr[1] * 255 + ptr[2] * 255 * 255;
                        greyPixelArray[i, j] = (int)((double)ptr[0] * 0.11 + (double)ptr[1] * 0.59 + (double)ptr[2] * 0.3);
                        ptr += 3;

                    }
                    ptr += remain;
                }
            }
            temp.UnlockBits(bmData);
            ShowPixels(pixelArray, bmData.Height, bmData.Width);

        }


        private void ShowPixels(int[,] pixels, int height, int width)
        {
            Form pixelForm = new Form();
            pixelForm.Height = 600;
            pixelForm.Width = 900;

            TextBox txtPixel = new TextBox();
            txtPixel.Multiline = true;

            txtPixel.Height = 600;
            txtPixel.Width = 900;
            txtPixel.ScrollBars = ScrollBars.Both;
            txtPixel.Margin = new Padding(20);
            StringBuilder stringPixels = new StringBuilder();
            for (int x = 0; x < height; x++)
            {
                for (int y = 0; y < width; y++)
                {
                    stringPixels.Append(pixels[x, y] + " ");

                }
                stringPixels.Append("\n");
            }

            txtPixel.Text = stringPixels.ToString();

            pixelForm.Controls.Add(txtPixel);
            pixelForm.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, pictureOriginal.Image.Width, pictureOriginal.Image.Height);
            Bitmap temp = new Bitmap(pictureOriginal.Image);
            BitmapData bmpData = temp.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int remain = bmpData.Stride - bmpData.Width * 3;
            unsafe
            {
                byte* ptr = (byte*)bmpData.Scan0;
                for (int i = 0; i < bmpData.Height; i++)
                {
                    for (int j = 0; j < bmpData.Width; j++)
                    {
                        ptr[0] = ptr[1] = ptr[2] = (byte)greyPixelArray[i, j];
                        //ptr[0] = (byte)(pixelArray[i, j] % 256);
                        //ptr[1] = (byte)((pixelArray[i, j] / 256) % 256);          //renkli çıktı için
                        //ptr[2] = (byte)((pixelArray[i, j] / 65536) % 256);
                        ptr += 3;
                    }
                    ptr += remain;
                }
            }
            temp.UnlockBits(bmpData);
            picGray.Image = temp;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(picGray.Image);

            for (int i = 0; i < picGray.Image.Height; i++)
            {
                for (int j = 0; j < picGray.Image.Width; j++)
                {
                    bmp.SetPixel(j,j,Color.Red);
                    if (i==j)
                    {
                       bmp.SetPixel(i, i, Color.Red);  
                       //bmp.SetPixel(bmp.Width-i,i,Color.Red);
                    }
                 }
              
            }
            picGray.Image = bmp;
        }
    }
}
