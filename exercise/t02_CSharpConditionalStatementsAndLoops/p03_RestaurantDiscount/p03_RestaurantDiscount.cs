using System;

namespace p03_RestaurantDiscount
{
    class p03_RestaurantDiscount
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            string hall = "";
            double price = 0;
            if (groupSize <= 50)
            {
                hall = "Small Hall";
                price = 2500;
            }
            else if (groupSize <= 100)
            {
                hall = "Terrace";
                price = 5000;
            }
            else if (groupSize <= 120)
            {
                hall = "Great Hall";
                price = 7500;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (package == "Normal")
            {
                price += 500;
                price *= 0.95;

            }
            else if (package == "Gold")
            {
                price += 750;
                price *= 0.90;
            }
            else if (package == "Platinum")
            {
                price += 1000;
                price *= 0.85;
            }
           
            double pricePerPerson = price / groupSize;

            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
        }
    }
}
