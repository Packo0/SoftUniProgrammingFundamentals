using System;

namespace p06_IntervalOfNumbers
{
    class p06_IntervalOfNumbers
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int start = Math.Min(firstNum, secondNum);
            int end = Math.Max(firstNum, secondNum);

            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
