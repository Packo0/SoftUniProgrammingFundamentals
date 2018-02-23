using System;
using System.Collections.Generic;
using System.Linq;

namespace p07_CountNumbers
{
    class p07_CountNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] counts = new int[1001];

            for (int i = 0; i < numbers.Count; i++)
            {
                counts[numbers[i]]++;
            }

            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] != 0)
                {
                    Console.WriteLine($"{i} -> {counts[i]}");
                }
            }
        }
    }
}
