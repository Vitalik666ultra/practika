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

namespace zadanie_4._3
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

        string cvodrat;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 10; i <= 20; i++)
            {
                cvodrat = $"{Math.Pow(i, 2)} ";
            }
            MessageBox.Show(cvodrat);
        }
    }
}
