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

namespace zadanie_4._1
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int TT = 0;
        int RR = 0;
        bool EE = false;
        private void QQ_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TT = Convert.ToInt32(TBA.Text);
                RR = Convert.ToInt32(TBB.Text);
                Doom.Content = "";
                if (TT >= RR)
                {
                    Doom.Content = "ошибка";
                }
                else
                {
                    for (int a = TT + 1; a < RR; a++)
                    {
                        if (EE)
                        {
                            if (a % 2 == 0)
                                continue;
                            else
                                Doom.Content += $"{a} ";
                        }
                        else
                        {
                            Doom.Content += $"{a} ";
                        }
                    }
                }
            }
            catch
            {
                Doom.Content = "ошибка";
            }
        }

        private void change_Click(object sender, RoutedEventArgs e)
        {
            Doom.Content = "";
            EE = !EE;
        }
    }
}