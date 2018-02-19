using System;

namespace p10_CubeProperties
{
    class p10_CubeProperties
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            if (parameter == "face")
            {
                double face = CalculateFace(side);
                Console.WriteLine($"{face:F2}");
            }
            else if (parameter == "space")
            {
                double space = CalculateSpace(side);
                Console.WriteLine($"{space:F2}");
            }
            else if (parameter == "volume")
            {
                double volume = CalculateVolume(side);
                Console.WriteLine($"{volume:F2}");
            }
            else if (parameter == "area")
            {
                double area = CalculateArea(side);
                Console.WriteLine($"{area:F2}");
            }
        }

        static double CalculateFace(double side)
        {
            return Math.Sqrt(2 * side * side);
        }

        static double CalculateSpace(double side)
        {
            return Math.Sqrt(3 * side * side);
        }

        static double CalculateVolume(double side)
        {
            return side * side * side;
        }

        static double CalculateArea(double side)
        {
            return side * side * 6;
        }
    }
}
