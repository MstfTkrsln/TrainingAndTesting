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

namespace TonajHesaplama
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

        const double demir32=6.313;
        const double demir26 = 4.163;
        const double demir12 =0.888;
        const double kosebent80 = 9.63;
        

        private double demir32metre;
        private double demir26metre;
        private double demir12metre;
        private double kosebent80Metre;
        private double kaynakYuzde = 0;

        private double total = 0;
        private void btnHesapla_Click(object sender, RoutedEventArgs e)
        {

           demir32metre = 0;
          demir26metre = 0;
          demir12metre = 0;
          kosebent80Metre = 0;

            try
            {
                if (txtDemir32.Text != string.Empty)
                    demir32metre = double.Parse(txtDemir32.Text);

                if (txtDemir26.Text != string.Empty)
                    demir26metre = double.Parse(txtDemir26.Text);

                if (txtDemir12.Text != string.Empty)
                    demir12metre = double.Parse(txtDemir12.Text);

                if (txtKosebent80.Text != string.Empty)
                    kosebent80Metre = double.Parse(txtKosebent80.Text);

                total = (demir32metre*demir32) + (demir26metre*demir26) + (demir12metre*demir12) +
                        (kosebent80Metre*kosebent80);

                if (txtKaynak.Text != string.Empty)
                {
                    kaynakYuzde = double.Parse(txtKaynak.Text);
                    if (kaynakYuzde <= 100 && kaynakYuzde >= 0)
                        total = total+(total/100)*kaynakYuzde;

                }
                    

                lblTotal.Content = total + " kg";



            }
            catch (Exception)
            {
                MessageBox.Show("Veriler hatalı girildi. Lütfen kontrol ediniz...", "Hatalı Veri Girişi",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }


        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("              İksa Tonaj Hesaplama"+ Environment.NewLine+ Environment.NewLine+
                "Developer : mustafa.tekeraslan@gmail.com"+ Environment.NewLine+ Environment.NewLine
                +"                                                            17.11.2014", "Program Hakkında",
                   MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
