﻿using System;

namespace p03MilesToKilometers
{
    class p03_MilesToKilometers
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());

            double kilometers = miles * 1.60934;

            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
