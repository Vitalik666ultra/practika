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

namespace _4
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


        int Crystal = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(gold.Text);
            if (a>11)
            {
                a -= 12;
                Crystal += 1;
                label2.Text = $"{Crystal}";
                goldQuantity.Foreground = Brushes.Black;
                gold.Text = $"{a}";
            }
            else
            {
                goldQuantity.Foreground = Brushes.Red;
                goldQuantity.Content = "Недостаточно денег для покупки!";
            }
        }

        private void g_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(gold.Text);
            if (a > 59)
            {
                a -= 60;
                Crystal += 5;
                label2.Text = $"{Crystal}";
                goldQuantity.Foreground = Brushes.Black;
                gold.Text = $"{a}";
            }
            else
            {
                goldQuantity.Foreground = Brushes.Red;
                goldQuantity.Content = "Недостаточно денег для покупки!";
            }
        }
    }
}
