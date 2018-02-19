using System;

namespace p03_WaterOverflow
{
    class p03_WaterOverflow
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            byte liters = 0;
            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());

                if (current > 255 || liters > 255 || liters + current > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    liters += (byte)current;
                }
            }

            Console.WriteLine(liters);
        }
    }
}
