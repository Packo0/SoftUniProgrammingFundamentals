using System;
using System.Collections.Generic;
using System.Linq;

namespace p03_SumAdjacentEqualNumbers
{
    class p03_SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            while (true)
            {
                bool isFound = false;
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i - 1] == numbers[i])
                    {
                        numbers[i - 1] = numbers[i] + numbers[i];
                        numbers.Remove(numbers[i]);
                        isFound = true;
                    }
                }

                if (!isFound)
                {
                    break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
