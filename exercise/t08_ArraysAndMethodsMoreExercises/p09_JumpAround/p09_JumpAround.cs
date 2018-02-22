using System;
using System.Linq;

namespace p09_JumpAround
{
    class p09_JumpAround
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var sumOfElements = 0;

            for (int i = 0; i < numbers.Length;)
            {
                var steps = numbers[i];
                sumOfElements += numbers[i];

                if (i + steps < numbers.Length)
                {
                    i = i + steps;
                }
                else if (i - steps >= 0)
                {
                    i = i - steps;
                }
                else
                {
                    break;
                }
            }  

            Console.WriteLine(sumOfElements);
        }
    }
}
