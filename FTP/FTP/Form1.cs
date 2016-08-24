using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace FTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                ftpConnection1.Connect();
                string[] files = ftpConnection1.GetFiles();
                ListFiles.Items.AddRange(files);
                ftpConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ftpConnection1.Connect();

            if (DialogResult.OK == folderBrowserDialog1.ShowDialog()) ;
            string path= folderBrowserDialog1.SelectedPath.ToString();
            ftpConnection1.DownloadFile(path,ListFiles.SelectedItem.ToString());
            MessageBox.Show(ListFiles.SelectedItem.ToString() + "  is Downloaded.","Download",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
            ftpConnection1.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ftpConnection1.Connect();

            openFileDialog1.Filter = "All files|*.*";

            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
            string path = openFileDialog1.FileName;
            string filename = openFileDialog1.SafeFileName.ToString();
            
            ftpConnection1.UploadFile(path, filename);

            MessageBox.Show(filename + "  is Uploaded.", "Upload", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ftpConnection1.Close();
           
        }


    }
}
