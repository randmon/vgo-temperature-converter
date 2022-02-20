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

        private void ConvertToCelsius(object sender, RoutedEventArgs e)
        {
            ConvertBox(fahrenheitTextBox, x => (x - 32) / 1.8);
        }

        private void ConvertToFahrenheit(object sender, RoutedEventArgs e)
        {
            ConvertBox(celsiusTextBox, x => x * 1.8 + 32);
        }

        private void ConvertBox(TextBox t, Func<double, double> conversion)
        {
            try
            {
                var val = double.Parse(t.Text);
                var res = Math.Round(conversion(val), 2);
                t.Text = res.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Please insert a numeric value", "", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
