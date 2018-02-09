using System;

namespace p11_ConvertSpeedUnits
{
    class p11_ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            double totalSeconds = hours * 3600 + minutes * 60 + seconds;
            double meterPerSeconds = distanceInMeters / totalSeconds;

            Console.WriteLine($"{meterPerSeconds:F7}");

            double kmPerHours = meterPerSeconds * 3.6;

            Console.WriteLine($"{kmPerHours:F7}");

            double milesPerHours = kmPerHours / 1.609;

            Console.WriteLine($"{milesPerHours:F7}");
        }
    }
}
