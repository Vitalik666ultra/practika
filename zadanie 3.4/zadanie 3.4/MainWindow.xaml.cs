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

namespace zadanie_3._4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(UwU.Text) >= 0)
                {
                    if (Convert.ToInt32(UwU.Text) < 14)
                    {
                        label1.Content = "промежуток [0 - 14]";
                    }
                    if (Convert.ToInt32(UwU.Text) > 14 && Convert.ToInt32(UwU.Text) < 35)
                    {
                        label1.Content = "промежуток [15 - 35]";
                    }
                    if (Convert.ToInt32(UwU.Text) > 35 && Convert.ToInt32(UwU.Text) <= 50)
                    {
                        label1.Content = "промежуток [36 - 50]";
                    }
                    if (Convert.ToInt32(UwU.Text) >= 50 && Convert.ToInt32(UwU.Text) <= 100)
                    {
                        label1.Content = "промежуток [50 - 100]";
                    }
                    else if (Convert.ToInt32(UwU.Text) > 100)
                    {
                        MessageBox.Show("Вне диапозона");
                        label1.Content = "";
                    }
                }
                else
                {
                    MessageBox.Show("Вне диапозона");
                }
            }
            catch
            {
                MessageBox.Show("Некорекно");
            }
        }


    }
}