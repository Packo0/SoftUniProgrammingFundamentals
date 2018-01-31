using System;

namespace p04_BeverageLabels
{
    class p04_BeverageLabels
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyPer100 = int.Parse(Console.ReadLine());
            int sugarPer100 = int.Parse(Console.ReadLine());

            double energyContent = volume * energyPer100 / 100.0;
            double sugarContent = volume * sugarPer100 / 100.0;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyContent}kcal, {sugarContent}g sugars");


        }
    }
}
