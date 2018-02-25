using System;
using System.Linq;

namespace p01_MaxSequenceOfEqualElements
{
    class p01_MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int count = 1;
            int bestCount = 1;
            int number = numbers[0];
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                    if (count > bestCount)
                    {
                        bestCount = count;
                        number = numbers[i];
                    }
                }
                else {
                    count = 1;
                }
            }

            for (int i = 0; i < bestCount; i++)
            {
                Console.Write(number);

                if (i != bestCount)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
}
