using System;
using System.Linq;

namespace p08_MostFrequentNumber
{
    class p08_MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] numbers =
                   Console.ReadLine()
                   .Split(' ')
                   .Select(int.Parse)
                   .ToArray();

            int[] counter = new int[numbers.Length];            
            int bestLength = 0;
            int maxNum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter[i]++;

                        if (counter[i] > bestLength)
                        {
                            bestLength = counter[i];
                            maxNum = numbers[i];
                        }
                    }
                }
            }

            Console.WriteLine(maxNum);
        }
    }
}
