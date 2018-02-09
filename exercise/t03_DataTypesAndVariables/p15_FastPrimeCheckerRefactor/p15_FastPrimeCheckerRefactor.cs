using System;

namespace p15_FastPrimeCheckerRefactor
{
    class p15_FastPrimeCheckerRefactor
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int currentNum = 0; currentNum <= number; currentNum++)
            {
                if (currentNum == 0 || currentNum == 1)
                {
                    continue;
                }

                bool isPrime = true;
                for (int divisor = 2; divisor <= Math.Sqrt(currentNum); divisor++)
                {
                    if (currentNum % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                Console.WriteLine($"{currentNum} -> {isPrime}");
            }

        }
    }
}
