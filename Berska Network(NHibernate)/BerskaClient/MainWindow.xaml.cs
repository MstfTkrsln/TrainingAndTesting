using System.Windows;
using BerskaClient.BerskaService;
using Entities;

namespace BerskaClient
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

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            StoreServiceClient storeServiceClient=new StoreServiceClient();

            Store newStore=new Store{Name = txtStoreName.Text};

            bool result = storeServiceClient.SaveStore(newStore);

            if (result)
            {
                MessageBox.Show("Mağaza Kaydedildi !","Success",MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show("Hata Oluştu !","Error",MessageBoxButton.OK);
            }

        }
    }
}
