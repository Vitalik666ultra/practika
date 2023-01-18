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
namespace zadanie_5._2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
		{
			InitializeComponent();
		}
		private void UU_Click(object sender, RoutedEventArgs e)
		{
			if (TBA.Text == "" || TBB.Text == "")
			{
				MessageBox.Show("Заполните все значения", "Конвертер валюты", MessageBoxButton.OK, MessageBoxImage.Error);
				return;
			}
			double a = double.Parse(TBA.Text);
			double b = double.Parse(TBB.Text);
			double c = Convert(a, b);
			MessageBox.Show("курс валюты " + c);
		}
		private double Convert(double sum, double kurs)
		{
			double result = sum * kurs;
			return result;
		}
    }
}