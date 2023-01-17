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

namespace zadanie_3._2_remaster
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(yy.Text);
            double b = Convert.ToDouble(xx.Text);
            string c = znak.Text;
            switch (c)
            {
                case "+":
                    q.Content = a + b;
                    break;
                case "-":
                    q.Content = a - b;
                    break;
                case "*":
                    q.Content = a * b;
                    break;
                case "/":
                    if (b != 0)
                        q.Content = a / b;
                    else
                        q.Content = "error";
                    break;
                default:
                    q.Content = "error";
                    break;
            }
        }
    }
}
