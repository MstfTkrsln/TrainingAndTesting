using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace SearcherApp
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
           
            MessageBox.Show("test");
            string siteAdress = "http://www.kartalyuvasi.com.tr/pinfo.asp?pid=43499";

            string keyword = txtKeyword.Text;
            
            string link = SearchTheSite(siteAdress, keyword);
            
            
           MessageBox.Show(link);

        }

        private string SearchTheSite(string siteAdress, string keyword)
        {

           

            //Regex r = new Regex("href=.[^\"]+");

            //foreach (Match m in r.Matches(htmlCodes))
            //{
            //    string link = m.Groups[1].Value;

            //    if (link.IndexOf("\"") > -1)

            //        link = link.Substring(0, link.IndexOf("\""));

            //    string metin = m.Groups[2].Value;
                
            // }
            WebClient client = new WebClient();
            Stream data;
            StreamReader reader;

            for (int i = 43500; i < 44000; i++)
            {
                txtcount.Text = i.ToString();

                 siteAdress = siteAdress.Replace((i - 1).ToString(), i.ToString());

                string htmlCodes = client.DownloadString(siteAdress);
                
                
                 if(htmlCodes.Contains("KODU"))
                     MessageBox.Show(htmlCodes);
            }



            return "";
        }
        
    }
}
