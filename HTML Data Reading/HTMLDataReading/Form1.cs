using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using NReadability;


namespace HTMLDataReading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetNewsText(textBox1.Text);
        }

        void GetNewsText(string url)
        {
            NReadabilityWebTranscoder TwebTranscoder  = new NReadability.NReadabilityWebTranscoder();
            bool b;
            string detail;

           
            string page = TwebTranscoder.Transcode(url, DomSerializationParams.CreateDefault(), out b, out detail);

   
            if (b)
            {
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(page);

               
                
                var body = doc.DocumentNode.SelectSingleNode("//div[@id='readInner']").InnerText;
                string title = doc.DocumentNode.SelectSingleNode("//title").InnerText;
               
               
                richTextBox1.Text =title.Trim();
                richTextBox2.Text = detail.Trim();
                richTextBox3.Text = body.Trim();


          

            }
           
        }

    }
}
