using System;

namespace p06_ReverseArrayOfStrings
{
    class p06_ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine().Split(' ');

            for (int i = strings.Length - 1; i  >= 0; i --)
            {
                Console.Write(strings[i]);

                if (i != 0)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
