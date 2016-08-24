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

namespace WpfBook7
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
Akademisyen akd=new Akademisyen(123,"Mustafa","Tekeraslan");

            text1.DataContext = akd;
            text2.DataContext = akd;
            text3.DataContext = akd;
        }

        
    }
}
