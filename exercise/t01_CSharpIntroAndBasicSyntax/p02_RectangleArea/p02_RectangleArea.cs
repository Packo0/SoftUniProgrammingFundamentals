using System;

namespace p02_RectangleArea
{
    class p02_RectangleArea
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());

            double area = sideA * sideB;

            Console.WriteLine($"{area:F2}");
        }
    }
}
