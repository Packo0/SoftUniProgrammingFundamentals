using System;

namespace p08_SumOfOddNumbers
{
    class p08_SumOfOddNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;
            int sum = 0;
            int currentNum = 1;

            while (counter < n)
            {
                counter++;
                Console.WriteLine(currentNum);
                sum += currentNum;
                currentNum += 2;              
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
