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

namespace Object
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.label1.Content=textBox1.Text;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.label1.Content = textBox2.Text;
        }

        private void MainWindow1_Loaded(object sender, RoutedEventArgs e)
        {
            string pluginPath = AppDomain.CurrentDomain.BaseDirectory + "Plugin\\Plugin.dll";

            Assembly asm = Assembly.LoadFile(pluginPath);

            IObject pluginbObject=(Object.IObject) asm.CreateInstance("Plugin.Plugin");

            pluginbObject.Initialize(this);
        }
    }
}
