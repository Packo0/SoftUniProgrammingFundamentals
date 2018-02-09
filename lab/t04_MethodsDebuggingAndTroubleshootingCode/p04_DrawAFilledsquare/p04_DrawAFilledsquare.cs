using System;

namespace p04_DrawAFilledsquare
{
    class p04_DrawAFilledsquare
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintDashes(n);
            for (int i = 1; i < n - 1; i++)
            {
                PrintMiddle(n);
            }

            PrintDashes(n);
        }

        private static void PrintMiddle(int n)
        {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }

            Console.WriteLine("-");
        }

        static void PrintDashes(int length)
        {
            Console.WriteLine(new string('-', length * 2));
        }
    }
}
