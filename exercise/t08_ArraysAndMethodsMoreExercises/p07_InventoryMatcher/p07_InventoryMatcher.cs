using System;
using System.Linq;

namespace p07_InventoryMatcher
{
    class p07_InventoryMatcher
    {
        static void Main(string[] args)
        {
            string[] nameOfProducts = Console.ReadLine().Split(' ');
            long[] quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            string product = Console.ReadLine();

            while (product != "done")
            {
                int indexOfProduct = Array.IndexOf(nameOfProducts, product);
                Console.Write($"{product} costs: {prices[indexOfProduct]}; ");
                Console.WriteLine($"Available quantity: {quantities[indexOfProduct]}");

                product = Console.ReadLine();
            }
        }
    }
}
