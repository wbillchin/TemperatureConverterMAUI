using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    static class ConvertTemperature
    {
        static public double convertCelsiusToFahrenheit(double inputTemperature)
        {
            // Convert Celsius to Fahrenheit

            return (inputTemperature * 9 / 5) + 32;
        }
    }
}
