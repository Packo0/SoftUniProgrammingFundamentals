using System;
using System.Collections.Generic;

namespace p03_MinerTask
{
    class p03_MinerTask
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> mines = new Dictionary<string, long>();
            string input = Console.ReadLine();

            string metal = "";
            int quantity = 0;

            while (input != "stop")
            {
                metal = input;
                quantity = int.Parse(Console.ReadLine());

                if (mines.ContainsKey(metal))
                {
                    mines[metal] += quantity;
                }
                else
                {
                    mines.Add(metal, quantity);
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in mines)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
