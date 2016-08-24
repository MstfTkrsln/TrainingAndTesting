using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HtmlAgilityPack;
using Rss;
namespace GetNews
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

        private void btnGetNews_Click(object sender, RoutedEventArgs e)
        {
           

            if (txtLink.Text==string.Empty)
            {
                MessageBox.Show("You must insert a news'link", "Invalid News Link", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
            else
            {
                try
                {
                    
                    RssFeed feed= RssFeed.Read(txtLink.Text);
                    RssChannel channel = feed.Channels[0];

                    foreach (RssItem item in channel.Items)
                    {
                        txtNews.Text += item.Description.ToString()+"\n";
                    }


                }
               
                

                //Uri url = null;
                //    try
                //    {
                //        url=new Uri(txtLink.Text); 
                //        WebClient client=new WebClient();

                //        string html = client.DownloadString(url);

                //        HtmlDocument document=new HtmlDocument();
                //        document.OptionFixNestedTags = true;
                //        document.LoadHtml(html);

            
                    catch (UriFormatException)
                    {
                        MessageBox.Show("You must right a RSS' link", "Invalid News Link", MessageBoxButton.OK,
                    MessageBoxImage.Error);
                        
                    }
                     
                
             }
            

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
