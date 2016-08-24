using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WinForms_Uygulamaları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread.CurrentThread.CurrentUICulture=new CultureInfo("de-DE");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm=new Form();
            frm.Height = 200;
            frm.Width = 300;
            frm.Text = "Form ShowDialog";
            frm.IsMdiContainer = true;
            

            Button b=new Button();
            b.Text = "Send";
            b.Left = frm.Height/2;
            b.Top = frm.Height/2;
            b.Height = 50;
            b.Width = 50;

            frm.Controls.Add(b);
           
            frm.ShowDialog();
        }

        private void Form1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Yardım Sayfası Hazır değil");
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Yardım için ietişime geçiniz");
        }
    }
}
