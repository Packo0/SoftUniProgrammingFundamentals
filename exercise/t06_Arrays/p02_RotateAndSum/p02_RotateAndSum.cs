using System;
using System.Linq;

namespace p02_RotateAndSum
{
    class p02_RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] numbers =
                    Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
            int k = int.Parse(Console.ReadLine());

            int[] sum = new int[numbers.Length];
            int len = numbers.Length;
            for (int i = 0; i < k; i++)
            {
                Rotate(numbers);

                for (int j = 0; j < len; j++)
                {
                    sum[j] += numbers[j];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }

        static void Rotate(int[] numbers)
        {
            int last = numbers[numbers.Length - 1];

            for (int i = numbers.Length - 1; i > 0; i--)
            {
                numbers[i] = numbers[i - 1];
            }

            numbers[0] = last;
        }
    }
}
