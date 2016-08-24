using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Threads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls= false;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.Name = "Main Thread";
            ThreadStart ts=new ThreadStart(ThreadRun);
            Thread thread=new Thread(ts);
            thread.Name = "ThredRun";
            thread.Start();

            MessageBox.Show("Running thread is : "+Thread.CurrentThread.Name);

            

        }

        private void ThreadRun()
        {
            MessageBox.Show("Running thread is : "+Thread.CurrentThread.ManagedThreadId);
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value = i;
               
                for (int j = 0; j < 100; j++)
                {
                    label1.Text = j.ToString();
                }
            }
        }

    }
}
