using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Linq_Wpf
{
    /// <summary>
    /// Interaction logic for Arama.xaml
    /// </summary>
    public partial class Arama : Window
    {
        public Arama()
        {

            InitializeComponent();
        }

        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnAra_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (rdAd.IsChecked == true)
                {


                    if(listView1.Items[0].ToString().Substring(7, 20).StartsWith(textBox1.Text))
                    {
                        var ic = listView1.Items[0];
                        listView1.Items.Clear();
                        listView1.Items.Add(ic);

                    }

                    




                }
                
            }


        }

    }
}
