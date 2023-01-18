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

namespace zadanie_4._5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double Token;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                double zp = Convert.ToDouble(TBA.Text);
                int YR = Convert.ToInt32(TBB.Text);
                if (YR > 0)
                {
                    if (YR < 5)
                    {
                        Token = zp + (zp * 0.1d);
                    }
                    else if (YR >= 5 && YR < 10)
                    {
                        Token = zp + (zp * 0.15d);
                    }
                    else if (YR >= 10 && YR < 15)
                    {
                        Token = zp + (zp * 0.25d);
                    }
                    else if (YR >= 15 && YR < 20)
                    {
                        Token = zp + (zp * 0.35d);
                    }
                    else if (YR >= 20 && YR < 25)
                    {
                        Token = zp + (zp * 0.45d);
                    }
                    else if (YR >= 25)
                    {
                        Token = zp + (zp * 0.50d);
                    }
                }
                WW.Text = Token.ToString();
            }
            catch
            {
                WW.Text = "ошибка, данные некорректны";
            }
        }
    }
}
