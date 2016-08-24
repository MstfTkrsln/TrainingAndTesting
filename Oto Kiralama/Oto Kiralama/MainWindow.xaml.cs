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

namespace Oto_Kiralama
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
            
            cmbMarka.ItemsSource = Enum.GetNames(typeof (Marka));

            for (int i = 1950; i <= 2014; i++)
            {
                cmbYil.Items.Add(i);

            }

            cmbRenk.ItemsSource = Enum.GetNames(typeof (ConsoleColor));

        }

        private void cmbMarka_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            switch (cmbMarka.SelectedValue.ToString())
            {
                case  "Mercedes":
                {
                    cmbModel.ItemsSource = Enum.GetNames(typeof (Mercedes));break;
                }

                case "Audi":
                {
                    cmbModel.ItemsSource = Enum.GetNames(typeof (Audi));break;
                }
                   case "Opel":
                {
                    cmbModel.ItemsSource = Enum.GetNames(typeof (Opel));break;
                }  

            }
           
            
        }
        Araba[] Araclar = new Araba[0];
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            Array.Resize(ref Araclar,Araclar.Length+1);


            Araclar[Araclar.Length-1] = new Araba()
            {
                Marka = cmbMarka.SelectedValue.ToString(),
                Model = cmbModel.SelectedValue.ToString(),
                Renk = cmbRenk.SelectedValue.ToString(),
                Yıl = (int)cmbYil.SelectedValue
            };
            
            listAraba.Items.Add(Araclar[0].ToString());

            //MessageBox.Show(Araclar[Araclar.Length - 1].ToString(), "Araç Kaydedildi", MessageBoxButton.OK,
            // MessageBoxImage.Information);
            Listele(Araclar);
        }

        private void btnSil_Click(object sender, RoutedEventArgs e)
        {
            Araclar[listAraba.SelectedIndex].Remove();
            Listele(Araclar);
            
        }

        void Listele(Araba[] a)

        {
            listAraba.Items.Clear();
            
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Marka!=null)
                listAraba.Items.Add(a[i]);
            }
            
        }
    }
}
