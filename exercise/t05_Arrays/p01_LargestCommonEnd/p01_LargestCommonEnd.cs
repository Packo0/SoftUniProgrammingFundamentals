using System;

namespace p01_LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split(' ');
            string[] second = Console.ReadLine().Split(' ');

            int length = Math.Min(first.Length, second.Length);
            int startCount = 0;
            int endCount = 0;

            for (int i = 0; i < length; i++)
            {
                if (first[i] == second[i])
                {
                    startCount++;
                }

                if (first[first.Length - 1 - i] == second[second.Length - 1 - i])
                {
                    endCount++;
                }
            }

            Console.WriteLine(startCount > endCount ? startCount : endCount);

        }
    }
}
