using System;
using System.Linq;

namespace p01_ArrayStatistics
{
    class p01_ArrayStatistics
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Average = {numbers.Average()}");
        }
    }
}
