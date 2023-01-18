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
namespace zadanie_5._5
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        int a = 1;
        int b = 0;
        int Vladimir = 0;
        private void Factorial(int value)
        {
            if (b < Vladimir)
            {
                b++;
                a *= b;
                Factorial(Vladimir);
            }
            else
            {
                MessageBox.Show(a.ToString());

            }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Vladimir = Convert.ToInt32(TBA.Text);
                a = 1;
                b = 0;
                Factorial(Vladimir);

            }
            catch
            {
                MessageBox.Show("Ошибка введите число");
            }
        }
    }
}