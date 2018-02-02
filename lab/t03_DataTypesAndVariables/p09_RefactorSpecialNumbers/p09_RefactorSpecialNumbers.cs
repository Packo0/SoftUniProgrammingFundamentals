using System;

namespace p09_RefactorSpecialNumbers
{
    class p09_RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int sum = 0;
                int currentNum = i;
                while (currentNum > 0)
                {
                    int digit = currentNum % 10;
                    sum += digit;
                    currentNum /= 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
