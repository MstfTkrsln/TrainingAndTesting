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
using BusinessLayer;
using EntityLayer;

namespace Kutuphane
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
            KitapListele();
            KategoriListele();
        }

        private void KategoriListele()
        {
            List<Kategori> KategoriListesi = BLKategori.SelectList();

            cmbKategori.ItemsSource = KategoriListesi;

            cmbKategori.Text = cmbKategori.Items[0].ToString();

        
        }

        private void KitapListele()
        {
            List<Kitap> kitapListesi = BLKitap.SelectList();

           datagridKitaplar.ItemsSource = kitapListesi;
        }

        private void btnEkle_Click(object sender, RoutedEventArgs e)
        {
           
            Kitap kitap=new Kitap()
            {
                ADI = txtAdi.Text,
                KATEGORIADI =((Kategori) cmbKategori.SelectedItem).ADI,
                KATEGORIID = ((Kategori)cmbKategori.SelectedItem).ID,
                SAYFASAYISI =Convert.ToInt16(txtSayfa.Text),
                YAZAR = txtYazar.Text
            };

            if (BLKitap.Insert(kitap) > 0)
                MessageBox.Show("Kitap Eklendi.");
            else
                MessageBox.Show("Kitap Eklerken Hata Oluştu.");

            KitapListele();
        }

        private void btnSil_Click(object sender, RoutedEventArgs e)
        {
            if (datagridKitaplar.SelectedItem != null)
            {
                int id = ((Kitap) datagridKitaplar.SelectedItem).ID;

                BLKitap.Delete(id);

                KitapListele();

                MessageBox.Show("Kitap Silindi...");
            }
                
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (datagridKitaplar.SelectedItem != null)
            {
               Kitap kitap = new Kitap()
                {
                    ID = ((Kitap)datagridKitaplar.SelectedItem).ID,
                    ADI = ((Kitap) datagridKitaplar.SelectedItem).ADI,
                    KATEGORIADI = ((Kitap) datagridKitaplar.SelectedItem).KATEGORIADI,
                    KATEGORIID = ((Kitap) datagridKitaplar.SelectedItem).ID,
                    SAYFASAYISI = ((Kitap) datagridKitaplar.SelectedItem).SAYFASAYISI,
                    YAZAR = ((Kitap) datagridKitaplar.SelectedItem).YAZAR
                };

                BLKitap.Update(kitap);

                MessageBox.Show("Kitap Güncellendi...");

                KitapListele();
            }
        }
    }
}
