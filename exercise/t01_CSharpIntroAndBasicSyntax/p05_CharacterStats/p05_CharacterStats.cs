using System;

namespace p05_CharacterStats
{
    class p05_CharacterStats
    {
        static void Main(string[] args)
        {
            string heroName = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            string currentHealthAsText = new string('|', currentHealth);
            string maxHealthAsText = new string('.', maxHealth - currentHealth);
            string currentEnergyAsText = new string('|', currentEnergy);
            string maxtEnergyAsText = new string('.', maxEnergy - currentEnergy);

            Console.WriteLine($"Name: {heroName}");
            Console.WriteLine($"Health: |{currentHealthAsText}{maxHealthAsText}|");
            Console.WriteLine($"Energy: |{currentEnergyAsText}{maxtEnergyAsText}|");
        }
    }
}
