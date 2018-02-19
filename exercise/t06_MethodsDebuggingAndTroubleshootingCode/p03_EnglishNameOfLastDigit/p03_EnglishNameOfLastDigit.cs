using System;

namespace p03_EnglishNameOfLastDigit
{
    class p03_EnglishNameOfLastDigit
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            number = Math.Abs(number);

            string lastDigit = GetLastDigit(number);
            Console.WriteLine(lastDigit);
        }

        private static string GetLastDigit(long number)
        {
            long lastDigit = number % 10;

            switch (lastDigit)
            {
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "zero";
            }
        }
    }
}
