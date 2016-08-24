using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using Microsoft.Win32;


namespace File_Class__WPF_
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
        
        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
           FileDialog fd=new SaveFileDialog();
            fd.Title = "Create";
            
            fd.DefaultExt = ".txt";
            fd.Filter="Txt Files (*.txt)|*.txt|Data Files(*.dat)|*.dat";

            Nullable<bool> result = fd.ShowDialog();
            
            if (result==true)
            {
                lblPath.Content = fd.FileName;

                File.Create(fd.FileName);

            }
           
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            listFile.Items.Clear();
            FileDialog fd=new OpenFileDialog();
            fd.DefaultExt = ".txt";
            fd.Filter = "Txt Files (*.txt)|*.txt|Data Files(*.dat)|*.dat";

            Nullable<bool> result = fd.ShowDialog();

            if (result==true)
            {
                lblPath.Content = fd.FileName;
                foreach (var item in File.ReadLines(fd.FileName,Encoding.Default))
                {
                    listFile.Items.Add(item);
                }

                //listFile.ItemsSource=File.ReadAllLines(fd.FileName,Encoding.Default);
                //itemsource kullanırsak items.add yapamıyoruz.
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            FileDialog fd = new SaveFileDialog();
            fd.DefaultExt = ".txt";
            fd.Filter = "Txt Files (*.txt)|*.txt|Data Files(*.dat)|*.dat";

            if (lblPath.Content == null)
            {
                Nullable<bool> result = fd.ShowDialog();

                if (result == true)
                    lblPath.Content = fd.FileName;
            }
            

            List<string> str = new List<string>();
            foreach (var item in listFile.Items)
                 {
                     str.Add(item.ToString());
                }
            
        File.WriteAllLines(lblPath.Content.ToString(),str);
            
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            listFile.Items.Add(textBox1.Text);
            textBox1.Text = string.Empty;
        }

        private void btnProp_Click(object sender, RoutedEventArgs e)
        {
            if (lblPath.Content != null)
            {
                label1.Content = File.GetCreationTime(lblPath.Content.ToString());
                label2.Content = File.GetLastWriteTime(lblPath.Content.ToString());
                label3.Content = File.GetLastAccessTime(lblPath.Content.ToString());
            }
        }

        private void btnSrOpen_Click(object sender, RoutedEventArgs e)
        {
          
            FileDialog fd = new OpenFileDialog();
            fd.DefaultExt = ".txt";
            fd.Filter = "Txt Files (*.txt)|*.txt|Data Files(*.dat)|*.dat";

            
                
                Nullable<bool> result = fd.ShowDialog();
                 
                if (result == true)
                {
                    StreamReader sw=new StreamReader(fd.FileName);
                    lblPath.Content = fd.FileName;
                    
                    while (!sw.EndOfStream)
                    {
                       listFile.Items.Add(sw.ReadLine());
                        
                    }
                    sw.Close();
                }
                
            
            
        }

        

      
    }
}