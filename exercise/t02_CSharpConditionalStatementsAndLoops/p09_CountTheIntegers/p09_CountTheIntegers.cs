using System;

namespace p09_CountTheIntegers
{
    class p09_CountTheIntegers
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 0; i < 100; i++)
            {
                bool isNumber = int.TryParse(Console.ReadLine(), out int result);

                if (isNumber)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(count);
        }
    }
}
