using System;
using System.Numerics;

namespace p13_Factorial
{
    class p13_Factorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(n));

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
    }
}
