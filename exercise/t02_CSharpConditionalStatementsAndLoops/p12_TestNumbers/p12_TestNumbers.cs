using System;

namespace p12_TestNumbers
{
    class p12_TestNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());

            int sum = 0;
            int count = 0;
            bool isReached = false;
            for (int i = n; i >= 1; i--)
            {
                if (sum >= maxSum)
                {
                    break;
                }

                for (int j = 1; j <= m; j++)
                {
                    sum += i * j * 3;
                    count++;

                    if (sum >= maxSum)
                    {
                        isReached = true;
                        break;
                    }
                }
            }

            Console.WriteLine($"{count} combinations");

            if (isReached)
            {
                Console.WriteLine($"Sum: {sum} >= {maxSum}");
            }
            else
            {
                Console.WriteLine($"Sum: {sum}");
            }

        }
    }
}
