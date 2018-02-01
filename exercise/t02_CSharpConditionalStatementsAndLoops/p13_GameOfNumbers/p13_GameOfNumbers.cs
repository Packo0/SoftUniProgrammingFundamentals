using System;

namespace p13_GameOfNumbers
{
    class p13_GameOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            int combinations = 0;
            for (int i = m; i >= n; i--)
            {
                for (int j = n; j <= m; j++)
                {
                    combinations++;
                    if (i + j == magic)
                    {
                        Console.WriteLine($"Number found! {i} + {j} = {magic}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{combinations} combinations - neither equals {magic}");
        }
    }
}
