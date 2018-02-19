using System;

namespace p04_SieveOfEratosthenes
{
    class p04_SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] isPrime = new bool[n + 1];

            for (int i = 2; i <= n; i++)
            {
                isPrime[i] = true;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            for (int i = 2; i <= n; i++)
            {
                if (isPrime[i])
                {
                    Console.Write(i);
                    if (i != n - 1)
                    {
                        Console.Write(" ");
                    }

                }
            }

            Console.WriteLine();
        }
    }
}
