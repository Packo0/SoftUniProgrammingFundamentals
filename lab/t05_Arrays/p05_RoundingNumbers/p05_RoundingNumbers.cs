using System;
using System.Linq;

namespace p05_RoundingNumbers
{
    class p05_RoundingNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                double rounded = Math.Round(numbers[i], MidpointRounding.AwayFromZero);

                Console.WriteLine($"{numbers[i]} => {rounded}");
            }
        }
    }
}
