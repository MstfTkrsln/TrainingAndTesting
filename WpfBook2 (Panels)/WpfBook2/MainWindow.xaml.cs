using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfBook2
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
            UniformGrid cerceve= new UniformGrid();

            cerceve.Rows = 7;
            cerceve.Columns = 7;
            for (int i = 0; i < 49; i++)
            {
                Rectangle rt=new Rectangle();
                rt.Height = 60;
                rt.Width = 60;
                if (i%2==0)
                {
                    rt.Fill=new SolidColorBrush(Colors.Red);
                }
                else
                {
                    rt.Fill=new SolidColorBrush(Colors.Purple);

                }

                cerceve.Children.Add(rt);
            }
            gridSatranc.Children.Add(cerceve);


            Rectangle rt1=new Rectangle();
            rt1.Fill=new SolidColorBrush(Colors.Aqua);
            rt1.Height = 50;
            rt1.Width = 50;
            rt1.HorizontalAlignment = HorizontalAlignment.Stretch;
            gridRowAndColumn.Children.Add(rt1);
            Grid.SetRow(rt1,1);
            Grid.SetColumn(rt1,1);
        }
    }
}
