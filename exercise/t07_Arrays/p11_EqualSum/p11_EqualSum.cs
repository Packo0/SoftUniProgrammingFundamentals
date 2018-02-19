using System;
using System.Linq;

namespace p11_EqualSum
{
    class p11_EqualSum
    {
        static void Main(string[] args)
        {
            int[] numbers =
                   Console.ReadLine()
                   .Split(' ')
                   .Select(int.Parse)
                   .ToArray();
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int left = 0; left < i; left++)
                {
                    leftSum += numbers[left];
                }

                for (int right = i + 1; right < numbers.Length; right++)
                {
                    rightSum += numbers[right];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }

                leftSum = 0;
                rightSum = 0;
            }

            Console.WriteLine("no");
        }
    }
}
