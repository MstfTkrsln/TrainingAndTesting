using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Linq_Wpf
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

    private void txtDt_GotFocus(object sender, RoutedEventArgs e)
        {
            txtDt.Text = string.Empty;
        }

        private void txtDt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtDt.Text == String.Empty)
            {
                txtDt.Text = txtDt.Tag.ToString();
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Uyeler uyeler=new Uyeler(txtAd.Text,txtSoyad.Text,txtTc.Text,Convert.ToDateTime(txtDt.Text));
            
            listView1.Items.Add(new {Ad=txtAd.Text,Soyad=txtSoyad.Text,Tc=txtTc.Text,Dt=txtDt.Text});

            Cleaner();


        }

        private void Cleaner()
        {
            txtAd.Text = String.Empty;
            txtSoyad.Text=String.Empty;
            txtTc.Text = String.Empty;
            txtDt.Text = txtDt.Tag.ToString();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
           
            txtDt.Tag = txtDt.Text.Trim();
        }

        private void btnAra_Click(object sender, RoutedEventArgs e)
        {
            btnAra.IsEnabled = false;
            Arama a=new Arama();

            foreach (var item in listView1.Items)
            {
                a.listView1.Items.Add(item);
            }
            a.Show();
            
            
        }

        public void aktif()
        {
            btnAra.IsEnabled = true;
        }

       
    }
}
