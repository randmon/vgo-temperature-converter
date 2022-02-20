using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

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

        /*private void ConvertCelsius()
        {
            //fahrenheitTextBox.Text = Convert(celsiusTextBox, x => x * 1.8 + 32);
            //kelvinTextBox.Text = Convert(celsiusTextBox, x => x + 273.15);
        }

        private void ConvertFahrenheit()
        {
            //celsiusTextBox.Text = Convert(fahrenheitTextBox, x => (x - 32) / 1.8);
            //kelvinTextBox.Text = Convert(fahrenheitTextBox, x => (x + 459.67) * 5/9);
        }

        private void ConvertKelvin()
        {
            //celsiusTextBox.Text = Convert(kelvinTextBox, x => x - 273.15);
            //fahrenheitTextBox.Text = Convert(kelvinTextBox, x => x * 9/5 - 459.67);
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
        }*/
    }

    public class CelsiusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var kelvin = (double)value;
            var celsius = kelvin - 273.15;

            return celsius.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var celsius = double.Parse((string)value);
            var kelvin = celsius + 273.15;

            return kelvin;
        }
    }

    public class FahrenheitConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var kelvin = (double)value;
            var fahrenheit = kelvin * 1.8 - 459.67;

            return fahrenheit.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var fahrenheit = double.Parse((string)value);
            var kelvin = (fahrenheit + 459.67) / 1.8;

            return kelvin;
        }
    }
}
