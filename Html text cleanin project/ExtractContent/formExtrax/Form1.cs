using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NReadability;

namespace formExtrax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getcontent(textBox1.Text);
        }
        private string getcontent(string url)
        {


            var t = new NReadability.NReadabilityWebTranscoder();
            bool b;
            string detail = "";
            string page = t.Transcode(url, DomSerializationParams.CreateDefault(), out b, out detail);

            if (b)
            {
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(page);

              
                // var imgUrl = doc.DocumentNode.SelectSingleNode("//meta[@property='og:image']").Attributes["content"].Value;
                var dd = doc.DocumentNode.SelectSingleNode("//div[@id='readInner']").InnerText;
                var tt = doc.DocumentNode.SelectSingleNode("//title").InnerText;
                richTextBox2.Text = detail;
                richTextBox1.Text =  dd;
                    return dd;
            }
            return "";
        }
    }
}
