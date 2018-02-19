using System;
using System.Linq;

namespace p03_FoldAndSum
{
    class p03_FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] numbers = //{ 4, 3, -1, 2, 5, 0, 1, 9, 8, 6, 7, -2 };
            Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

            int k = numbers.Length / 4;
            int[] left = new int[k];
            int[] right = new int[k];
            int[] sum = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                left[i] = numbers[i];
                right[i] = numbers[i + 3 * k];
            }

            for (int i = 0; i < k; i++)
            {
                sum[i] = left[k - 1 - i];
                sum[i + k] = right[k - 1 - i];
                sum[i] += numbers[k + i];
                sum[i + k] += numbers[2 * k + i];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
