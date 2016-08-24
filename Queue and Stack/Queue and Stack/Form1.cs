using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Queue_and_Stack
{
    public partial class Form1 : Form
    {
        stack<string> st=new stack<string>(); 
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            st.Add(textBox1.Text);
            
            textBox1.Text = string.Empty;
            
            textBox1.Focus();
            refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            st.Sil();
            refresh();
            
        }

        private void refresh() 
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            foreach (var item in st.st.ToArray())
            {
                listBox1.Items.Add(item);
            }
            foreach (var item in st.qu.ToArray())
            {
                listBox2.Items.Add(item);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            st.st.Clear();
            st.qu.Clear();
            refresh();
        }
    }
}
