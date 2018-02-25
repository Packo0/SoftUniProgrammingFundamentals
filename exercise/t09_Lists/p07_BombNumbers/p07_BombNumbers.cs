using System;
using System.Collections.Generic;
using System.Linq;

namespace p07_BombNumbers
{
    class p07_BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] bombPower = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int bomb = bombPower[0];
            int power = bombPower[1];

            while (numbers.Contains(bomb))
            {
                int bombIndex = numbers.IndexOf(bomb);

                if (bombIndex + power <= numbers.Count && bombIndex - power >= 0)
                {
                    numbers.RemoveRange(bombIndex - power, 2 * power + 1);
                }
                else if (bombIndex + power >= numbers.Count)
                {
                    numbers.RemoveRange(bombIndex - power, power + 1 + numbers.Count - 1 - bombIndex);
                }
                else if (bombIndex - power < 0)
                {
                    numbers.RemoveRange(0, bombIndex + power + 1);
                }
                else if (bombIndex - power < 0 && bombIndex + power > numbers.Count)
                {
                    numbers.Clear();
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
