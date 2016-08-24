using System; 
using System.Configuration; 
using System.IO; 
using System.Net;
using System.Net.Mime;
using System.Windows; 
using System.Xml; 
using System.Xml.Linq;

namespace Film_Analiz__IMDB_
{

    public partial class MainWindow : Window
    {          
        
      
        string imdbQuery = @"http://www.deanclatworthy.com/imdb/?q={0}&type=xml"; 
        string proxyName = ConfigurationManager.AppSettings["proxyName"]; 
        string proxyPort = ConfigurationManager.AppSettings["proxyPort"]; 
        string proxyUsername = ConfigurationManager.AppSettings["proxyUsername"]; 
        string proxyPassword = ConfigurationManager.AppSettings["proxyPassword"]; 
        WebClient webClient = null;
       
        
        public MainWindow() 
        { 
            
            InitializeComponent(); 
            webClient = GetWebClient(); 
        }
 
        private MemoryStream GetMemoryStream(string query) 
        { 
            MemoryStream memoryStream = new MemoryStream(webClient.DownloadData(query)); 
            return memoryStream; 
        }
 
        private WebClient GetWebClient() 
        { 
            WebProxy proxy = new WebProxy(proxyName, Convert.ToInt32(proxyPort)); 
            proxy.Credentials = new NetworkCredential(proxyUsername, proxyPassword); 
            WebClient client = new WebClient(); 
            client.Proxy = proxy; 
            return client; 
        }
 
        private void btnFind_Click(object sender, RoutedEventArgs e) 
        { 
           
            imdbQuery
            MemoryStream memoryStream = GetMemoryStream(string.Format(imdbQuery, txtMovieName.Text)); 
            XmlTextReader reader = new XmlTextReader(memoryStream); 
            XDocument document = XDocument.Load(reader); 
            reader.Close(); 
            memoryStream.Close(); 
            if (document.Root.HasElements) 
            { 
                Movie movie = new Movie(); 
                movie.ImdbId = document.Root.Element("imdbid").Value; 
                movie.Url = document.Root.Element("imdburl").Value; 
                movie.Genres = document.Root.Element("genres").Value; 
                movie.Languages = document.Root.Element("languages").Value; 
                movie.Country = document.Root.Element("country").Value; 
                movie.Votes = document.Root.Element("votes").Value; 
                movie.Rating = document.Root.Element("rating").Value; 
                movie.Runtime = document.Root.Element("runtime").Value; 
                movie.Title = document.Root.Element("title").Value; 
                movie.Year = document.Root.Element("year").Value;
 
                grdMovie.DataContext = movie; 
            } 
        } 
    } 
}

