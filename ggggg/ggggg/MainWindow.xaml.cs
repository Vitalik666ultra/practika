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

namespace ggggg
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
        bool money = false;
        int age = 10;
        string text ="деньги";
        char answer= 'A';
        double nimber = 0.7;
        long cat = 9;
        byte information = 23;
        object apple = 3.2;
        ushort manpower = 23500;
        decimal formula= 0.5m;
    }
}
