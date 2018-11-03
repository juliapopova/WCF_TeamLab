using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WCF_Example;

namespace Graphics
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Graphic(c);   
                        
        }
        double c = 0.0001;
        
        public void Graphic(double c)
        {
            LinearGradientBrush myLinearGradientBrush =
          new LinearGradientBrush();
            myLinearGradientBrush.StartPoint = new Point(0, 0);
            myLinearGradientBrush.EndPoint = new Point(1, 0);

            myLinearGradientBrush.GradientStops.Add(
                new GradientStop(Colors.Red, 0.0));
            myLinearGradientBrush.GradientStops.Add(
                new GradientStop(Colors.LimeGreen, 0.2 + c));
            myLinearGradientBrush.GradientStops.Add(
                new GradientStop(Colors.LimeGreen, 0.8 - c));
            myLinearGradientBrush.GradientStops.Add(
                new GradientStop(Colors.Red, 1.0));
            myRect1.Fill = myLinearGradientBrush;

        }
        private void Start_Click(object sender, RoutedEventArgs e)
        {
           // for (int i = 0; i < 100; i++)
            //{
                Graphic(c);
                c += 0.01;
            if (c >= 0.3)
                c = 0.0001;
               // System.Threading.Thread.Sleep(10);
               // }
        }
    }
}
