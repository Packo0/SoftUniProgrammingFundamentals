using System;

namespace p16_ComparingFloats
{
    class p16_ComparingFloats
    {
        static void Main(string[] args)
        {
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());

            double eps = 0.000001;

            if (Math.Abs(numberA - numberB) < eps)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
