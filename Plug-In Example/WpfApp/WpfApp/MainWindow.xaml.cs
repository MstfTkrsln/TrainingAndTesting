using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using ApplicationObjects;

namespace WpfApp
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

        private void btnMessage1_Click(object sender, RoutedEventArgs e)
        {
            this.myAppObj.RaiseMessageButton1Event();
        }

        private void btnMessage2_Click(object sender, RoutedEventArgs e)
        {
           this.myAppObj.RaiseMessageButton2Event();
        }

        
        private AppObj myAppObj=new AppObj();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            myAppObj.MessageButton1_Click+= new EventHandler(myAppObj_MessageButton1_Click);

            myAppObj.MessageButton2_Click += new EventHandler(myAppObj_MessageButton2_Click);

            string plugInPath = System.AppDomain.CurrentDomain.BaseDirectory + "PlugIns\\PlugIn.dll";

            Assembly asm = Assembly.LoadFile(plugInPath);

            object instance = asm.CreateInstance("PlugIn.PlugIn", true);

           ((ApplicationObjects.IAppObject) instance).Inıtialize(myAppObj);
        }

        void myAppObj_MessageButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Title + " " +sender.ToString());
        }

        void myAppObj_MessageButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Title + " " + sender.ToString());
        }
    }
}
