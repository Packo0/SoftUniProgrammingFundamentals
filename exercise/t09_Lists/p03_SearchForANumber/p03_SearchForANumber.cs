using System;
using System.Collections.Generic;
using System.Linq;

namespace p03_SearchForANumber
{
    class p03_SearchForANumber
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] items = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var result = numbers.Take(items[0]).Skip(items[1]).ToList();

            if (result.Contains(items[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
