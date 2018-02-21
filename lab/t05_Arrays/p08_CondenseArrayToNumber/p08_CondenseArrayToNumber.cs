using System;
using System.Linq;

namespace p08_CondenseArrayToNumber
{
    class p08_CondenseArrayToNumber
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int len = numbers.Length;

            do
            {
                for (int i = 0; i < len - 1; i++)
                {
                    numbers[i] = numbers[i] + numbers[i + 1];
                }

                len--;
            } while (len > 1);

            Console.WriteLine(numbers[0]);
        }
    }
}
