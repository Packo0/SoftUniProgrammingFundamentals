using System;
using System.Linq;

namespace p04_GrabAndGo
{
    class p04_GrabAndGo
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            
            int sumLength = -1;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] == num)
                {
                    sumLength = i;
                    break;
                }
            }

            long sum = 0;
            for (int i = 0; i < sumLength; i++)
            {
                sum += numbers[i];
            }

            if (sumLength < 0)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}
