using System;

namespace p05_TemperatureConversion
{
    class p05_TemperatureConversion
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = FahrenheitTocelsius(fahrenheit);
            Console.WriteLine($"{celsius:F2}");
        }

        static double FahrenheitTocelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9.0;
            return celsius;
        }
    }
}
