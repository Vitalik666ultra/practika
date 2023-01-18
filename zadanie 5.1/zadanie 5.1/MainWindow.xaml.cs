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

namespace zadanie_5._1
{  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Add(int x, int y)
        {
            MessageBox.Show("Результат сложения: " + (x + y));
        }

        private void Sub(int x, int y)
        {
            MessageBox.Show("Результат вычитания: " + (x - y));
        }

        private void Mul(int x, int y)
        {
            MessageBox.Show("Результат умножения: " + (x * y));
        }

        private void Div(int x, int y)
        {
            if (y == 0)
            {
                MessageBox.Show("Деление на ноль запрещёно");
                return;
            }

            MessageBox.Show("Результат деления: " + ((decimal)x / y));
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int a = int.Parse(DA.Text);
                int b = int.Parse(TBB.Text);
                string c = TBA.Text;

                if (DA.Text == "" || TBB.Text == "" || TBA.Text == "")
                {
                    MessageBox.Show("Заполните все значения");
                    return;
                }

                if (c == "+")
                {
                    Add(a, b);
                }
                else if (c == "-")
                {
                    Sub(a, b);
                }
                else if (c == "*")
                {
                    Mul(a, b);
                }
                else if (c == "/")
                {
                    Div(a, b);
                }
                else
                {
                    MessageBox.Show("Ввёден неизвестный оператор. Введите одно из значений: +, -, /, *");
                }
            }
            catch
            {
                MessageBox.Show("введите в 1 и 2 поле числа");
            }
        }
    }

}
