using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace _6_ls
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
            try
            {
                string a = Convert.ToString(q.Text);
                int b = Convert.ToInt32(z.Text);
                string c = Convert.ToString(w.Text);
                if (b > 0)
                {

                    rat.Content = $"Вас зовут {a} вам {b} лет твой пол {c}";
                }
                else
                {
                    label.Content = "Ответ не подходит возраст отрицательный";
                }
            }
            catch
            {
                label.Content = "Имя и пол писать буквами, а позраст цифрами";
            }
        }

    }
}
