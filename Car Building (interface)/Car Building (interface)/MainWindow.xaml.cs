using System;

using System.Windows;

using CarBuild;

namespace Car_Building__interface_
{
  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            ICar car = CarCreate.Create((Cars) comboBox3.SelectedValue);
            if (car == null)
                this.Close();
               
            car.Body();
            car.Brush((ConsoleColor) comboBox1.SelectedValue);

            car.Doors(Convert.ToInt32(comboBox2.SelectedValue));
            car.Tyres();

            MessageBox.Show(car.ToString());


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
                foreach (ConsoleColor colors in Enum.GetValues(typeof (ConsoleColor)))
                {
                    comboBox1.Items.Add(colors);
                }
            comboBox2.Items.Add(2);
            comboBox2.Items.Add(4);

                foreach (Cars car in Enum.GetValues(typeof (Cars)))
                {
                    comboBox3.Items.Add(car);
                   
                }
            

        }
    }
}
