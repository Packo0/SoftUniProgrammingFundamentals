using System;

namespace p09_MultiplicationTable
{
    class p09_MultiplicationTable
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());

            int times = 10;
            for (int i = 1; i <= times; i++)
            {
                Console.WriteLine($"{theInteger} X {i} = {theInteger * i}");
            }
        }
    }
}
