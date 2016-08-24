using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Caching;
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


namespace CacheConceptWpf
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

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            ObjectCache cache = MemoryCache.Default;
            string fileContents = cache["filecontents"] as string;

            if (fileContents == null)
            {
                CacheItemPolicy p = new CacheItemPolicy();
                p.AbsoluteExpiration =DateTimeOffset.Now.AddSeconds(20.0);

                List<string> filePaths = new List<string>();
                filePaths.Add(@"C:\Users\Administrator\Documents\Visual Studio 2010\Projects\Caching Example\CacheFile.txt");

                p.ChangeMonitors.Add(new HostFileChangeMonitor(filePaths));

                // Fetch the file contents.
                fileContents = File.ReadAllText(@"C:\Users\Administrator\Documents\Visual Studio 2010\Projects\Caching Example\CacheFile.txt") + "\n" + DateTime.Now.ToString();

                cache.Set("filecontents", fileContents, p);

            }
            MessageBox.Show(fileContents);
 
        }
    }
}
