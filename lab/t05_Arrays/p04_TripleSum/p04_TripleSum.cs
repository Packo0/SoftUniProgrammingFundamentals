using System;
using System.Linq;

namespace p03_TripleSum
{
    class p03_TripleSum
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isContainsTheSum = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        if (numbers[i] + numbers[j] == numbers[k])
                        {
                            isContainsTheSum = true;
                            Console.WriteLine($"{numbers[i]} + {numbers[j]} == {numbers[k]}");
                            break;
                        }
                    }
                }
            }

            if (!isContainsTheSum)
            {
                Console.WriteLine("No");
            }
        }
    }
}
