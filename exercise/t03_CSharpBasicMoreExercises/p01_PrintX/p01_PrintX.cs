using System;

namespace p01_PrintX
{
    class p01_PrintX
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // top part
            int spacesIn = n - 2;
            int spacesOut = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write(new String(' ', spacesOut));
                Console.Write("x");
                Console.Write(new String(' ', spacesIn));
                Console.Write("x");
                Console.WriteLine(new String(' ', spacesOut));
                
                spacesOut++;
                spacesIn -= 2;
            }

            //middle row
            Console.Write(new string(' ', spacesOut));
            Console.Write("x");
            Console.WriteLine(new string(' ', spacesOut));

            //bottom part
            for (int i = 1; i <= n / 2; i++)
            {
                spacesOut--;
                spacesIn += 2;

                Console.Write(new String(' ', spacesOut));
                Console.Write("x");
                Console.Write(new String(' ', spacesIn));
                Console.Write("x");
                Console.WriteLine(new String(' ', spacesOut));
            }

        }
    }
}
