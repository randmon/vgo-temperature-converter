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

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertCelsius(object sender, RoutedEventArgs e)
        {
            fahrenheitTextBox.Text = Convert(celsiusTextBox, x => x * 1.8 + 32);
            kelvinTextBox.Text = Convert(celsiusTextBox, x => x + 273.15);
        }

        private void ConvertFahrenheit(object sender, RoutedEventArgs e)
        {
            celsiusTextBox.Text = Convert(fahrenheitTextBox, x => (x - 32) / 1.8);
            kelvinTextBox.Text = Convert(fahrenheitTextBox, x => (x + 459.67) * 5/9);
        }

        private void ConvertKelvin(object sender, RoutedEventArgs e)
        {
            celsiusTextBox.Text = Convert(kelvinTextBox, x => x - 273.15);
            fahrenheitTextBox.Text = Convert(kelvinTextBox, x => x * 9/5 - 459.67);
        }

        private string Convert(TextBox t, Func<double, double> conversion)
        {
            try
            {
                var val = double.Parse(t.Text);
                var res = Math.Round(conversion(val), 2);
                return res.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Please insert a numeric value", "", MessageBoxButton.OK, MessageBoxImage.Warning);
                return "";
            }
        }
    }
}
