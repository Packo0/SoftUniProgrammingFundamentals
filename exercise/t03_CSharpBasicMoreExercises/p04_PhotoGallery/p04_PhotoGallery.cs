using System;

namespace p04_PhotoGallery
{
    class p04_PhotoGallery
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());


            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year} {hour:D2}:{minute:D2}");
            Console.Write("Size: ");
            if (size < 1000)
            {
                Console.WriteLine($"{size}B");
            }
            else if (size < 1000000)
            {
                Console.WriteLine($"{size / 1000}KB");
            }
            else
            {
                Console.WriteLine($"{size / 1000000}MB");
            }

            Console.Write($"Resolution: {width}x{height} ");
            if (width > height)
            {
                Console.WriteLine("(landscape)");
            }
            else if (width < height)
            {
                Console.WriteLine("(portrait)");
            }
            else
            {
                Console.WriteLine("(square)");
            }
        }
    }
}
