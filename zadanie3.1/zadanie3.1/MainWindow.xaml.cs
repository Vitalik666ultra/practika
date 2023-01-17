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

namespace zadanie3._1
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            string a = Convert.ToString(TBA.Text);
                switch (a)
                {
                    case "снег":
                        TBB.Text = "snow";
                        break;
                    case "Молния":
                        TBB.Text = "lightning";
                        break;
                    case "дождь":
                        TBB.Text = "rain";
                        break;
                    case "Солнечно":
                        TBB.Text = "sunny";
                        break;
                    case "Метель":
                        TBB.Text = "snowstorm";
                        break;
                    case "Ветренно":
                        TBB.Text = "windy";
                        break;
                    case "Жарко":
                        TBB.Text = "Hot";
                        break;
                    case "Холодно":
                        TBB.Text = "Cold";
                        break;
                    case "Сухо":
                        TBB.Text = "Dry";
                        break;
                    case "Град":
                        TBB.Text = "Hail";
                        break;
                    case "Ураган":
                        TBB.Text = "Hurricane";
                        break;
                    default:
                        TBB.Text = "Ошибка";
                        break;
            }
        }
    }
}
