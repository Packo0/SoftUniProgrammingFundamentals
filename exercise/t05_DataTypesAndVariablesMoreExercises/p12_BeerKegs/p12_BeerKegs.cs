using System;

namespace p12_BeerKegs
{
    class p12_BeerKegs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double biggestVolume = double.MinValue;
            string biggestModel = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double currentVolume = Math.PI * radius * radius * height;

                if (currentVolume >= biggestVolume)
                {
                    biggestModel = model;
                    biggestVolume = currentVolume;
                }
            }

            Console.WriteLine(biggestModel);
        }
    }
}
