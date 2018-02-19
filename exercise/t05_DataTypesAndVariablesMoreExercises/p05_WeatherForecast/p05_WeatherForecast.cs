using System;

namespace p05_WeatherForecast
{
    class p05_WeatherForecast
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            bool isSunny = sbyte.TryParse(number, out sbyte result);
            bool isCloudy = int.TryParse(number, out int result1);
            bool isWindy = long.TryParse(number, out long result2);
            bool isRainy = double.TryParse(number, out double result3);

            if (isSunny)
            {
                Console.WriteLine("Sunny");
            }
            else if (isCloudy)
            {
                Console.WriteLine("Cloudy");
            }
            else if (isWindy)
            {
                Console.WriteLine("Windy");
            }
            else if (isRainy)
            {
                Console.WriteLine("Rainy");
            }
        }
    }
}
