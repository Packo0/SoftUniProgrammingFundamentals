using System;

namespace p07_MathPower
{
    class p07_MathPower
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = RaiseToPower(number, power);

            Console.WriteLine(result);
        }

        static double RaiseToPower(double number, int power)
        {
            double result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
