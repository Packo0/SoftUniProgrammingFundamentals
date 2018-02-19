using System;
using System.Numerics;

namespace p14_FactorialTrailingZeroes
{
    class p14_FactorialTrailingZeroes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger result = Factorial(n);
            int zeroes = GetTrailingZeroes(result);
            Console.WriteLine(zeroes);
        }

        static BigInteger Factorial(int n)
        {
            BigInteger fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }

            return fact;
        }

        static int GetTrailingZeroes(BigInteger number)
        {
            int zeroes = 0;

            while (number % 10 == 0)
            {
                zeroes++;
                number /= 10;
            }

            return zeroes;
        }
    }
}
