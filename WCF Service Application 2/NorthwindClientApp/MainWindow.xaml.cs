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
using NorthwindClientApp.CustomerService;

namespace NorthwindClientApp
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

        private void btnGetCustomer_Click(object sender, RoutedEventArgs e)
        {
            listCustomer.Items.Clear();
          
            CustomerServiceClient proxy = new CustomerServiceClient("BasicHttpBinding_CustomerService");

            var customers=proxy.GetCustomerByName(txtName.Text);

            foreach (Customer customer in customers)
            {
                listCustomer.Items.Add(customer.CustomerId+" "+customer.CompanyName+" "+customer.Country);
            }
           


        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            listCustomer.Items.Clear();
            

            CustomerServiceClient proxy = new CustomerServiceClient("BasicHttpBinding_CustomerService");

            var customers = proxy.GetCustomerByCountry(txtCountry.Text);

            foreach (Customer customer in customers)
            {
                listCustomer.Items.Add(customer.CustomerId + " " + customer.CompanyName + " " + customer.Country);
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            CustomerServiceClient proxy = new CustomerServiceClient("BasicHttpBinding_CustomerService");

           
            proxy.AddCustomer(txtCustomerId.Text,txtCompnayName.Text,txtAddress.Text,txtCity.Text);

            
            
        }
    }
}
