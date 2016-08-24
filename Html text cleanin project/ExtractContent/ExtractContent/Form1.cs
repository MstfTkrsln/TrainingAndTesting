using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtractContent
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text=  getcontent(textBox1.Text);
        }
        private string getcontent(string url) {
      

            var t = new NReadability.NReadabilityWebTranscoder();
            bool b;
            string page = t.Transcode(url, out b);

            if (b)
            {
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(page);

                var title = doc.DocumentNode.SelectSingleNode("//title").InnerText;
               // var imgUrl = doc.DocumentNode.SelectSingleNode("//meta[@property='og:image']").Attributes["content"].Value;
                return doc.DocumentNode.SelectSingleNode("//div[@id='readInner']").InnerText;
            }
            return "";
        }
    }
}
