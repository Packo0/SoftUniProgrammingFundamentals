using System;

namespace p04_TouristInformation
{
    class p04_TouristInformation
    {
        static void Main(string[] args)
        {
            string imperialUnit = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());

            switch (imperialUnit)
            {
                case "miles":
                    Console.WriteLine($"{value} {imperialUnit} = {value * 1.6:F2} kilometers");
                    break;
                case "inches":
                    Console.WriteLine($"{value} {imperialUnit} = {value * 2.54:F2} centimeters");
                    break;
                case "feet":
                    Console.WriteLine($"{value} {imperialUnit} = {value * 30:F2} centimeters");
                    break;
                case "yards":
                    Console.WriteLine($"{value} {imperialUnit} = {value * 0.91:F2} meters");
                    break;
                case "gallons":
                    Console.WriteLine($"{value} {imperialUnit} = {value * 3.8:F2} liters");
                    break;
            }
        }
    }
}
