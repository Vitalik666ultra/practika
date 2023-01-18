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

namespace zadanie_5._3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ii.Text == "")
                {
                    MessageBox.Show("Укажите число для подсчёта", "подсчёта числа");
                    return;
                }
                int ber = int.Parse(ii.Text);
                ccc(ber);
            }
            catch
            {
                MessageBox.Show("введите число");
            }
        }
        private void ccc(int number)
        {
            string POL;
            if (number >= 0)
                POL = "Положительное";
            else
                POL = "Отрицательное";
           
            string PROST = "Является ли простым: ";
            if (Class(number))
                PROST = PROST + "да";
            else
                PROST = PROST + "нет";

            
            string y2 = "Делится на 2: ";
            string y3 = "Делится на 3: ";
            string y5 = "Делится на 5: ";
            string y6 = "Делится на 6: ";
            string y9 = "Делится на 9: ";

            if (number % 2 == 0)
                y2 = y2 + "да";
            else
                y2 = y2 + "нет";

            if (number % 3 == 0)
                y3 = y3 + "да";
            else
                y3 = y3 + "нет";

            if (number % 5 == 0)
                y5 = y5 + "да";
            else
                y5 = y5 + "нет";

            if (number % 6 == 0)
                y6 = y6 + "да";
            else
                y6 = y6 + "нет";

            if (number % 9 == 0)
                y9 = y9 + "да";
            else
                y9 = y9 + "нет";
            infoBox.Text = POL + "\n" + PROST + "\n" + y2 + "\n" + y3 + "\n" + y5 + "\n" + y6 + "\n" + y9;
        }
        private bool Class(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}