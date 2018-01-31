using System;

namespace p06_TheatrePromotions
{
    class p06_TheatrePromotions
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
                return;
            }

            int price = 0;
            if (dayType == "Weekday")
            {
                if (18 < age && age <= 64)
                {
                    price = 18;
                }
                else
                {
                    price = 12;
                }
            }
            else if (dayType == "Weekend")
            {
                if (18 < age && age <= 64)
                {
                    price = 20;
                }
                else
                {
                    price = 15;
                }
            }
            else
            {
                if (0 <= age && age <= 18)
                {
                    price = 5;
                }
                else if (18 < age && age <= 64)
                {
                    price = 12;
                }
                else if (64 < age && age <= 122)
                {
                    price = 10;
                }
            }

            Console.WriteLine($"{price}$");
        }
    }
}
