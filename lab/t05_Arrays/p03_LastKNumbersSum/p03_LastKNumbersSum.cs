using System;

namespace p03_LastKNumbersSum
{
    class p03_LastKNumbersSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] numbers = new long[n];
            numbers[0] = 1;

            for (int i = 1; i < n; i++)
            {
                if (i - k >= 0)
                {
                    for (int j = i; j >= i - k; j--)
                    {
                        numbers[i] += numbers[j];
                    }
                }
                else
                {
                    for (int j = i; j >= 0; j--)
                    {
                        numbers[i] += numbers[j];
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
