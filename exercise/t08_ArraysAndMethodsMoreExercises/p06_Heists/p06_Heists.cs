using System;
using System.Linq;
using System.Numerics;

namespace p06_Heists
{
    class p06_Heists
    {
        static void Main(string[] args)
        {
            var prices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int jewel = prices[0];
            int gold = prices[1];

            string input = Console.ReadLine();
            string[] command = new string[2];
            if (input != "Jail Time")
            {
                command = input.Split(' ');
            }

            BigInteger totalExpences = 0;
            BigInteger totalEarnings = 0;
            while (command[0] != "Jail Time")
            {
                string loot = command[0];
                for (int i = 0; i < loot.Length; i++)
                {
                    if (loot[i] == '%')
                    {
                        totalEarnings += jewel;
                    }
                    else if (loot[i] == '$')
                    {
                        totalEarnings += gold;
                    }
                }

                totalExpences += int.Parse(command[1]);

                input = Console.ReadLine();
                if (input == "Jail Time")
                {
                    break;
                }

                command = input.Split(' ');
            }

            if (totalEarnings >= totalExpences)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalEarnings - totalExpences}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {totalExpences - totalEarnings}.");
            }
        }
    }
}
