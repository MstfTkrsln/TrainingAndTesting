using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Regular_Expression
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnHtml_Click(object sender, RoutedEventArgs e)
        {
            string newsLink =
                "http://www.hurriyet.com.tr/gundem/26504717.asp";
            HttpWebRequest myRequest = (HttpWebRequest) WebRequest.Create(newsLink);

            WebResponse myResponse = myRequest.GetResponse();

            
            StreamReader sr = new StreamReader(myResponse.GetResponseStream(), Encoding.Default);
            
            txtNews.Text = sr.ReadToEnd();

            Regex finder=new Regex("<h1(.*?)h1>");

           // txtNews.Text=Regex.Replace(txtNews.Text, @"<(.|\n)*?>",string.Empty);
            //tagleri siler

            Match finderMatch=Regex.Match(txtNews.Text, @"<\w",RegexOptions.IgnoreCase);

            MatchCollection mc = finder.Matches(txtNews.Text);
            foreach (Match match in mc)
            {
                txtFind.Text += match.ToString() + "\n";
            }

            //txtFind.Text = finderMatch.Value;
            sr.Close();

     
            //Encoding iso = Encoding.GetEncoding("ISO-8859-1");
            //Encoding utf8 = Encoding.UTF8;
            //byte[] utfBytes = utf8.GetBytes(news);
            //byte[] isoBytes = Encoding.Convert(utf8, iso, utfBytes);
            //txtNews.Text = iso.GetString(isoBytes);

        }
    }
}
