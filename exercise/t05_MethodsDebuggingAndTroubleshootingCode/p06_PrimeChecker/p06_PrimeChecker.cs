using System;

namespace p06_PrimeChecker
{
    class p06_PrimeChecker
    {
        static void Main(string[] args)
        {
            ulong  number = ulong.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
        }

        static bool IsPrime(ulong number)
        {
            if (number < 2)
            {
                return false;
            }

            for (ulong i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
