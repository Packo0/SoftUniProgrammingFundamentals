using System;

namespace p01_CenturiesToMinutes
{
    class p01_CenturiesToMinutes
    {
        static void Main(string[] args)
        {
            int centures = int.Parse(Console.ReadLine());
            int years = centures * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{centures} centures = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
