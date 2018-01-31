using System;

namespace p02_ChooseADrink2
{
    class p02_ChooseADrink2
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double price = 0;
            switch (profession)
            {
                case "Athlete": price = 0.7; break;
                case "Businessman":
                case "Businesswoman": price = 1.0; break;
                case "SoftUni Student": price = 1.7; break;
                default:
                    price = 1.2;
                    break;
            }

            double result = price * quantity;
            Console.WriteLine($"The {profession} has to pay {result:F2}.");
        }
    }
}
