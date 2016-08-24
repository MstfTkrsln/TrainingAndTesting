using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
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

namespace WPFBook1
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
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b=new Button();
            b.Content = "tıklama";
            b.HorizontalAlignment = HorizontalAlignment.Right;
            b.VerticalAlignment = VerticalAlignment.Center;
            b.Height = 20;
            b.Width = 50;
            comboBox1.Items.Add(b);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < 3; i++)
            {
                Image c=new Image();
                c.Height = 50;
                c.Width = 50;
                BitmapImage bitmap=new BitmapImage();

                int k = i + 1;
                c.Source = new ImageSourceConverter().ConvertFromString(@"..\..\images\i"+k+".jpg") as ImageSource;
                
                listBox1.Items.Add(c);
            }
           

        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            Image image = (Image) listBox1.SelectedValue;
            image1.Source = image.Source;
        }

        private byte R, G, B;
      
        private void b_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            B = Convert.ToByte(e.NewValue);
            rec.Fill=new SolidColorBrush(Color.FromRgb(R,G,B));
        }

        private void g_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            G = Convert.ToByte(e.NewValue);
            rec.Fill = new SolidColorBrush(Color.FromRgb(R, G, B));
        }

        private void r_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            B = Convert.ToByte(e.NewValue);
            rec.Fill = new SolidColorBrush(Color.FromRgb(R, G, B));
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            //Popup.IsOpen = true;
        }

        private void page1_Loaded(object sender, RoutedEventArgs e)
        {
            music.Play();
        }

        private void page1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            CancelEventArgs cancelEvent=new CancelEventArgs();
            //cancelEvent.Cancel = true;
            page1_Closing(sender,cancelEvent);
        }

       
        

     
    }
}
