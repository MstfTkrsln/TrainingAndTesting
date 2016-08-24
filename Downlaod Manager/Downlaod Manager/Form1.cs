using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
namespace Downlaod_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet=new SaveFileDialog();
            string Kayityeri;
            if(textBox1.Text.EndsWith(".zip"))
            {
                kaydet.Filter = "Zip|*.zip";
            }
            else if (textBox1.Text.EndsWith(".jpg"))
            {
                kaydet.Filter = "jpeg|.jpg";
            }
            if (kaydet.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Kayityeri = kaydet.FileName;
                WebClient indir=new WebClient();
                string hkc;
                hkc = Path.GetFileName(kaydet.FileName);
                lblIsım.Text = hkc.ToString();
                indir.DownloadProgressChanged += IndirProg;
                textBox1.ReadOnly = true;
                indir.DownloadStringAsync(new Uri(textBox1.Text),kaydet.FileName);
            }
            
        }

        private void IndirProg(object sender, DownloadProgressChangedEventArgs e)
        {
            Prgdownload.Value = e.ProgressPercentage;
            LblYuzde.Text = e.BytesReceived+"-"+e.TotalBytesToReceive;
        }

        private void tamamlandi()
        {
            Prgdownload.Value = 0;
            MessageBox.Show("Download Completed");
        }
    }
}
