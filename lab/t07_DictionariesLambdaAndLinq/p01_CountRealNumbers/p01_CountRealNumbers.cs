using System;
using System.Collections.Generic;
using System.Linq;

namespace p01_CountRealNumbers
{
    class p01_CountRealNumbers
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            SortedDictionary<double, int> numbersCount = new SortedDictionary<double, int>();

            foreach (var num in numbers)
            {
                if (numbersCount.ContainsKey(num))
                {
                    numbersCount[num]++;
                }
                else
                {
                    numbersCount[num] = 1;
                }
            }

            foreach (var num in numbersCount)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
