using System;

namespace p11_OddNumber
{
    class p11_OddNumber
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            while (num % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                num = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine($"The number is: {Math.Abs(num)}");
        }
    }
}
