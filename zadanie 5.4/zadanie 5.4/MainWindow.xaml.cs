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
namespace zadanie_5._4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double socialcredit = 700;
        void Plata(double po)
        {
            socialcredit -= po;
            string result = ($"Сумма долга: {700}\nВнесенно: {po}\n") + (socialcredit <= 0 ? $"Кредит погашен\nПереплата: {Math.Abs(socialcredit)}" : $"Осталось внести: {socialcredit}");
            MessageBox.Show(result);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double value1 = Convert.ToDouble(UWU.Text);
                Plata(value1);
            }
            catch
            {
                MessageBox.Show("Введите сумму цифрами");
            }
        }
    }
}