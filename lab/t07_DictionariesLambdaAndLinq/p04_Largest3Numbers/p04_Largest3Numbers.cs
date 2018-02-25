using System;
using System.Linq;

namespace p04_Largest3Numbers
{
    class p04_Largest3Numbers
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var largestThree = numbers.OrderByDescending(n => n).Take(3).ToArray();

            Console.WriteLine(string.Join(" ", largestThree));
        }
    }
}
