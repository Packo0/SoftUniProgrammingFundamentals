using System;

namespace p06_CalculateTriangleArea
{
    class p06_CalculateTriangleArea
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = GetTriangleArea(width, height);

            Console.WriteLine(area);
        }

        static double GetTriangleArea(double width, double height)
        {
            return (width * height) / 2;
        }
    }
}
