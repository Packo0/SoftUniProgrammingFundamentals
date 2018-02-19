using System;

namespace p10_SumOfChars
{
    class p10_SumOfChars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                sum += ch;
            }

            Console.WriteLine("The sum equals: " + sum);
        }
    }
}
