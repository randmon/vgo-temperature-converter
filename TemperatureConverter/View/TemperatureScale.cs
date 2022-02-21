using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public interface ITemperatureScale
    {
        string Name { get; }

        double ConvertToKelvin(double temperature);
        double ConvertFromKelvin(double temperature);
    }

    public class KelvinTemperatureScale : ITemperatureScale
    {
        public string Name => "Kelvin";

        public double ConvertFromKelvin(double temperature)
        {
            return Math.Round(temperature, 2);
        }

        public double ConvertToKelvin(double temperature)
        {
            return Math.Round(temperature, 2);
        }
    }

    public class CelsiusTemperatureScale : ITemperatureScale
    {
        public string Name => "Celsius";

        public double ConvertFromKelvin(double temperature)
        {
            return Math.Round(temperature - 273.15, 2);
        }

        public double ConvertToKelvin(double temperature)
        {
            return Math.Round(temperature + 273.15, 2);
        }
    }

    public class FahrenheitTemperatureScale : ITemperatureScale
    {
        public string Name => "Fahrenheit";

        public double ConvertFromKelvin(double temperature)
        {
            return Math.Round(temperature * 1.8 - 459.67, 2);
        }

        public double ConvertToKelvin(double temperature)
        {
            return Math.Round((temperature + 459.67) / 1.8, 2);
        }
    }
}
