using System;

namespace p15_NeighbourWars
{
    class p15_NeighbourWars
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;

            int round = 1;
            while (peshoHealth > 0 || goshoHealth > 0)
            {
                if (round % 2 == 0)
                {
                    //gosho
                    peshoHealth -= goshoDamage;
                    if (peshoHealth <= 0 || goshoHealth <= 0)
                    {
                        break;
                    }

                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }
                else
                {
                    //pesho
                    goshoHealth -= peshoDamage;
                    if (peshoHealth <= 0 || goshoHealth <= 0)
                    {
                        break;
                    }

                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");

                }

                if (round % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }

                round++;
            }

            if (peshoHealth <= 0)
            {
                Console.WriteLine($"Gosho won in {round}th round.");
            }
            else
            {
                Console.WriteLine($"Pesho won in {round}th round.");
            }
        }
    }
}
