using System;

namespace p10_MultiplicationTable2
{
    class p10_MultiplicationTable2
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());

            if (times > 10)
            {
                Console.WriteLine($"{theInteger} X {times} = {theInteger * times}");
                return;
            }
            for (int i = times; i <= 10; i++)
            {
                Console.WriteLine($"{theInteger} X {i} = {theInteger * i}");
            }
        }
    }
}
