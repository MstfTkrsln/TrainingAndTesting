using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dictionary;

namespace Dictionary__Winform_
{
    public partial class Form1 : Form
    {

        
        public Store<string, string> sozluk = new Store<string, string>();

        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            sozluk.Add(textBox1.Text, textBox2.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            label6.Text = sozluk.Get(textBox3.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = sozluk.Get(textBox5.Text) + " kelimesi silindi.!";
            sozluk.Remove(textBox5.Text);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Width = 700;
            listBox1.Items.Clear();
            
            foreach (var item in sozluk.tolist())
            {
                listBox1.Items.Add(item);
            }
        }


    }
}