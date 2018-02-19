using System;

namespace p12_MasterNumber
{
    class p12_MasterNumber
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            number = Math.Abs(number);
            for (long i = 1; i <= number; i++)
            {
                bool isPalindrome = IsPalindrome(i);
                long sumOfDigits = SumOfDigits(i);
                bool containsEvenDigit = ContainsEvenDigit(i);

                if (isPalindrome && (sumOfDigits % 7 == 0) && containsEvenDigit)
                {
                    Console.WriteLine(i);
                }
            }

        }

        static bool ContainsEvenDigit(long number)
        {
            bool containsEvenDigit = false;

            while (number != 0)
            {
                long digit = number % 10;
                if (digit % 2 == 0)
                {
                    containsEvenDigit = true;
                    break;
                }

                number /= 10;
            }

            return containsEvenDigit;
        }

        static long SumOfDigits(long number)
        {
            long sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }

        static bool IsPalindrome(long number)
        {
            string numberAsText = number.ToString();
            bool isPalindrome = false;
            for (int i = 0; i < numberAsText.Length / 2; i++)
            {
                if (numberAsText[i] == numberAsText[numberAsText.Length - 1 - i])
                {
                    isPalindrome = true;
                }
                else
                {
                    return false;
                }
            }

            return isPalindrome;
        }
    }
}
