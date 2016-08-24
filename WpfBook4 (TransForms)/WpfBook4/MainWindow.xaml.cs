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

namespace WpfBook4
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



        private void Transform()
        {
            TransformGroup group = new TransformGroup();

            group.Children.Add(new ScaleTransform(sliderScale.Value, sliderScale.Value));
            group.Children.Add(new RotateTransform(sliderRotate.Value));
            group.Children.Add(new TranslateTransform(sliderTranslate.Value, sliderTranslate.Value));

            ellipse.LayoutTransform = group;
            button2.LayoutTransform = group;
        }

        private void sliderScale_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Transform();
        }

        private void sliderTranslate_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Transform();
        }

        private void sliderRotate_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Transform();
        }
    }
}
