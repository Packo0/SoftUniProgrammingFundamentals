using System;
using System.Collections.Generic;

namespace p07_PrimesInGivenrange
{
    class p07_PrimesInGivenrange
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            var primes = FindPrimesInRange(start, end);

            for (int i = 0; i < primes.Count; i++)
            {
                if (i < primes.Count - 1)
                {
                    Console.Write(primes[i] + ", ");
                }
                else {
                    Console.WriteLine(primes[i]);
                }
            }
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primes = new List<int>();

            for (int currentNum = startNum; currentNum <= endNum; currentNum++)
            {
                bool isPrime = IsPrime(currentNum);

                if (isPrime)
                {
                    primes.Add(currentNum);
                }
            }
            return primes;
        }
    }
}
