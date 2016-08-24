using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Image_Processor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
          
            InitializeComponent();  
            btnRotate.Tag = "left";
            btnRotateRight.Tag = "right";
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
        
        private Processor pro;

        private void btnGray_Click(object sender, EventArgs e)
        {
            pro=new Processor(picOriginal.Image);


            picNew.Image = pro.DoGray();
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
         
            pro=new Processor(picOriginal.Image);

            picNew.Image = pro.DoNegative();
       
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            
            pro = new Processor(picOriginal.Image);
           
            
            if (((Button) sender).Tag=="left")
            {
             
            picNew.Image = pro.DoRotate();
            }
            else
            {
                picNew.Image = pro.DoRotate2();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            pro = new Processor(picOriginal.Image);

            picNew.SizeMode = PictureBoxSizeMode.AutoSize;
            picNew.Image = pro.Resize(Convert.ToInt32(txtX.Text),Convert.ToInt32(txtY.Text));
          

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            picNew.Height = picOriginal.Height;
            picNew.Width = picOriginal.Width;
            picNew.Image = picOriginal.Image;
            picNew.SizeMode=PictureBoxSizeMode.StretchImage;
            
        }

       

     
    }
}
