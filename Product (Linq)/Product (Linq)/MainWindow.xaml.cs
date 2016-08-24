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

namespace Product__Linq_
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

        private List<Product> ListProduct = new List<Product>();

        private void btnKaydet_Click(object sender, RoutedEventArgs e)
        {

            Product p = new Product(txtAd.Text, Convert.ToDecimal(txtFiyat.Text));


            ListProduct.Add(p);

            Listele(ListProduct);

        }
        private delegate decimal del(Product p); 

        
        

        private void Listele(List<Product> Lp)
        {
            del d= karar;
          
            listBox1.Items.Clear();

            var newlist = from liste in ListProduct
                orderby liste.Fiyat
                select new
                {
                    ad = liste.Ad,
                    fiyat = liste.Fiyat
                };

            foreach (var item in newlist)
            {
                listBox1.Items.Add(item);
            }
            //foreach (var item in Lp.OrderBy(karar))
            //{
            //    listBox1.Items.Add(item);
            //}
        }
        
        //private del d =x=> { return x.Fiyat > 3; };
        //del d=delegate(Product p) { return p.Fiyat > 3; };

        public decimal karar(Product pl)
        {

            return pl.Fiyat;

        }

    }
}
