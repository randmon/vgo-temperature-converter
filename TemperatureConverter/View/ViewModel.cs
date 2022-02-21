using System;
using System.Globalization;
using System.Windows.Data;
using System.ComponentModel;

namespace View
{
    public class ConverterViewModel : INotifyPropertyChanged
    {
        public double temperatureInKelvin;
        public double TemperatureInKelvin
        {
            get
            {
                return temperatureInKelvin;
            }
            set
            {
                temperatureInKelvin = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TemperatureInKelvin)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
