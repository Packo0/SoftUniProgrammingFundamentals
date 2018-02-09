using System;

namespace p09_MultiplyEvensByOdds
{
    class p09_MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);

            int result = GetMultipleOfEvenAndOdds(number);

            Console.WriteLine(result);
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            int sumEvens = GetSumOfEvenDigits(number);
            int sumOdds = GetSumOfOddDigits(number);
            return sumEvens * sumOdds;
        }

        private static int GetSumOfOddDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    sum += digit;
                }

                number /= 10;
            }

            return sum;
        }

        private static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }

                number /= 10;
            }

            return sum;
        }
    }
}
