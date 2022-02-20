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
    }

    public class TemperatureConverter : IValueConverter
    {
        public ITemperatureScale TemperatureScale { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var kelvin = (double)value;
            return this.TemperatureScale.ConvertFromKelvin(kelvin).ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var temperature = double.Parse((string)value);
            return this.TemperatureScale.ConvertToKelvin(temperature);
        }
    }
}
