using System;

namespace StaticEX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The boiling point of water is {Math.Floor(TempConverter.CelsiusToFahrenheit(100.0))} degrees fahrenheit.");
            Console.WriteLine($"In degrees celsius it is {Math.Floor(TempConverter.FahrenheitToCelsius(212.0))}.");
        }
    }
}
