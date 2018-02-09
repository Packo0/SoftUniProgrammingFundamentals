using System;

namespace p02_MaxMethod
{
    class p02_MaxMethod
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int biggest = GetMax(first, GetMax(second, third));
            Console.WriteLine(biggest);
        }

        private static int GetMax(int number1, int number2)
        {
            if (number1 > number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }
    }
}
