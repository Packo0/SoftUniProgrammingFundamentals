using System;
using System.Numerics;

namespace p03_Megapixels
{
    class p03_Megapixels
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            
            long megapixels = width * height;
            double result = Math.Round(megapixels / 1000000.0, 1);
            Console.WriteLine($"{width}x{height} => {result}MP");
        }
    }
}
