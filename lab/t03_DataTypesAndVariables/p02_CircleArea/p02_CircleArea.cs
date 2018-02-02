using System;

namespace p02_CircleArea
{
    class p02_CircleArea
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine($"{r * r * Math.PI:f12}");
        }
    }
}
