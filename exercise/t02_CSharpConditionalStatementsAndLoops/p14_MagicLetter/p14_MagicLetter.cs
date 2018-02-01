using System;

namespace p14_MagicLetter
{
    class p14_MagicLetter
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char last = char.Parse(Console.ReadLine());
            char skip = char.Parse(Console.ReadLine());

            for (char i = first; i <= last; i++)
            {
                for (char j = first; j <= last; j++)
                {
                    for (char k = first; k <= last; k++)
                    {
                        if (i == skip || j == skip || k == skip)
                        {
                            continue;
                        }

                        Console.Write($"{i}{j}{k} ");
                    }
                }
            }
        }
    }
}
