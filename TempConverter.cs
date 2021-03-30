using System;
using System.Collections.Generic;
using System.Text;

namespace StaticEX
{
    static class TempConverter
    {
        public static double FahrenheitToCelsius(double input)
        {
            double celsius = input;
            celsius -= 32;
            celsius *= 0.56;
            return celsius;            
        }

        public static double CelsiusToFahrenheit(double input)
        {
            double fahrenheit = input;
            fahrenheit *= 1.8;
            fahrenheit += 32;
            return fahrenheit;
        }
    }
}
