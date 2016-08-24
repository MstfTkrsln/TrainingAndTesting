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
using Test_Wpf_Project.MyFirstService;


namespace Test_Wpf_Project
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

        private void btn_service_Click(object sender, RoutedEventArgs e)
        {
            PersonClient personService = new PersonClient("WSHttpBinding_IPerson");

            Person person1 = personService.GetPerson();

           

            PersonListBox.Items.Add(person1.Name + " " + person1.Surname);
        }
    }
}
