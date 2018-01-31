using System;

namespace p12_NumberChecker
{
    class p12_NumberChecker
    {
        static void Main(string[] args)
        {
            bool isNumber = double.TryParse(Console.ReadLine(), out double result);

            if (isNumber)
            {
                Console.WriteLine("It is a number.");
            }
            else {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
