using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Plugin
{
    public class Plugin:Object.IObject
    {
        private Object.MainWindow window=null;

        public void Initialize(Object.MainWindow _window)
        {
            this.window = _window;

            window.button1.Click += new System.Windows.RoutedEventHandler(button1_Click);
            window.button2.Click += new System.Windows.RoutedEventHandler(button2_Click);
        }

        void button2_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MessageBox.Show(this.window.textBox2.Text);
        }

        void button1_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MessageBox.Show(this.window.textBox1.Text);
        }
    }
}
