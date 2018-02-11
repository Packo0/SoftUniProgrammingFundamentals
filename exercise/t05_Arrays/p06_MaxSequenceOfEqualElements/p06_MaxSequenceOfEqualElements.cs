using System;
using System.Linq;

namespace p06_MaxSequenceOfEqualElements
{
    class p06_MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            int[] numbers =
                   Console.ReadLine()
                   .Split(' ')
                   .Select(int.Parse)
                   .ToArray();

            int start = 0;
            int length = 1;
            int bestStart = 0;
            int bestLength = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] == numbers[i])
                {
                    length++;

                    if (bestLength < length)
                    {
                        bestLength = length;
                        bestStart = start;
                    }
                }
                else
                {
                    start = i;
                    length = 1;
                }
            }

            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write(numbers[i]);

                if (i != bestStart + bestLength)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
