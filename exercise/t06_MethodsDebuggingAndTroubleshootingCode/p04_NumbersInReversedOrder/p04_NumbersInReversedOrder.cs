using System;
using System.Linq;

namespace p04_NumbersInReversedOrder
{
    class p04_NumbersInReversedOrder
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            string reversedNum = GetReversedNum(number);

            Console.WriteLine(reversedNum);
        }

        private static string GetReversedNum(string number)
        {
            string result = String.Empty;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                result += number[i];
            }
            return result;
        }
    }
}
