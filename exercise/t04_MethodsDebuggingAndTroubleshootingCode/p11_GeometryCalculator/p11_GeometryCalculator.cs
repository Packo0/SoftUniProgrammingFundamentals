using System;

namespace p11_GeometryCalculator
{
    class p11_GeometryCalculator
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine().ToLower();

            switch (figureType)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    double area = GetTriangleArea(side, height);
                    Console.WriteLine($"{area:F2}");
                    break;
                case "square":
                    side = double.Parse(Console.ReadLine());
                    area = GetSquareArea(side);
                    Console.WriteLine($"{area:F2}");
                    break;
                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    height = double.Parse(Console.ReadLine());
                    area = GetRectangleArea(width, height);
                    Console.WriteLine($"{area:F2}");
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    area = GetCircleArea(radius);
                    Console.WriteLine($"{area:F2}");
                    break;
            }
        }

        static double GetTriangleArea(double side, double height)
        {
            return side * height / 2;
        }

        static double GetSquareArea(double side)
        {
            return side * side;
        }

        static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }

        static double GetCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
