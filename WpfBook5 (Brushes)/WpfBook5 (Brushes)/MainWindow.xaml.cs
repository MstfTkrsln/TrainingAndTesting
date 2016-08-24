using System;
using System.Collections.Generic;
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

namespace WpfBook5__Brushes_
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MediaPlayer oynt=new MediaPlayer();
            oynt.Open(new Uri(@"..\..\Videos\Wildlife.wmv",UriKind.Relative));

            VideoDrawing videod=new VideoDrawing();
            videod.Rect=new Rect(100,100,10,10);
            videod.Player = oynt;

            DrawingBrush fircam=new DrawingBrush();
            fircam.Drawing = videod;
            ellipseVideo.Fill = fircam;
            
            oynt.Play();
        }
        
        private void ellipseVideo_MouseEnter(object sender, MouseEventArgs e)
        {
            
            ellipseVideo.Margin=new Thickness(0,0,0,0);
            ellipseVideo.Width = 600;

        }

        private void ellipseVideo_MouseLeave(object sender, MouseEventArgs e)
        {
            ellipseVideo.Margin = new Thickness(380,12,0,0);
            ellipseVideo.Width = 300;
        }
    }
}
