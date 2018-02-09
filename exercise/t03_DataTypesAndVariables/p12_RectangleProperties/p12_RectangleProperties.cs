using System;

namespace p12_RectangleProperties
{
    class p12_RectangleProperties
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perimeter = 2 * (width + height);
            Console.WriteLine(perimeter);

            double area = width * height;
            Console.WriteLine(area);

            double diagonal = Math.Sqrt(width* width + height * height);
            Console.WriteLine(diagonal);
        }
    }
}
