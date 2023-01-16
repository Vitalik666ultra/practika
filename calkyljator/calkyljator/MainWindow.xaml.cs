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
namespace calkyljator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void decision_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (clock.SelectedIndex)
                {
                    case 0:
                        double a = Convert.ToDouble(Ruslik.Text);
                        double b = Convert.ToDouble(suslik1.Text);
                        otwet.Content = a + b;

                        break;

                    case 1:
                        a = Convert.ToDouble(Ruslik.Text);
                        b = Convert.ToDouble(suslik1.Text);
                        otwet.Content = a - b;
                        break;

                    case 2:
                        a = Convert.ToDouble(Ruslik.Text);
                        b = Convert.ToDouble(suslik1.Text);
                        if (b == 0)
                        {
                            info.Content = "На ноль делить нельзя";
                            info.Foreground = Brushes.Red;
                        }

                        else
                        {
                            otwet.Content = a / b;
                            info.Content = "";
                        }
                        break;

                    case 3:
                        a = Convert.ToDouble(Ruslik.Text);
                        b = Convert.ToDouble(suslik1.Text);
                        otwet.Content = a * b;
                        break;                                                                                                                                                                                                   


                    case 4:
                        a = Convert.ToDouble(Ruslik.Text);
                        otwet.Content =Math.Round(Math.Sin(a),4);
                        break;

                    case 5:
                        a = Convert.ToDouble(Ruslik.Text);
                        otwet.Content = Math.Round(Math.Cos(a),4);
                        break;

                    case 6:
                        a = Convert.ToDouble(Ruslik.Text);
                        otwet.Content = Math.Round(Math.Tan(a),4);
                        break;

                    case 7:
                        a = Convert.ToDouble(Ruslik.Text);
                        otwet.Content = 1 / Math.Round(Math.Tan(a),4);
                        break;
                }
            }
            catch
            {
                otwet.Content = "Ошибка";
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}