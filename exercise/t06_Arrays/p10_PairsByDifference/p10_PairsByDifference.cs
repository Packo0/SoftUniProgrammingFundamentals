using System;
using System.Linq;

namespace p10_PairsByDifference
{
    class p10_PairsByDifference
    {
        static void Main(string[] args)
        {
            int[] numbers =
                   Console.ReadLine()
                   .Split(' ')
                   .Select(int.Parse)
                   .ToArray();
            int diff = int.Parse(Console.ReadLine());
            int numOfPairs = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + diff == numbers[j])
                    {
                        numOfPairs++;
                    }
                }
            }

            Console.WriteLine(numOfPairs);
        }
    }
}
