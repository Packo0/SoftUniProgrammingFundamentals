using System;

namespace p09_MakeAWord
{
    class p09_MakeAWord
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write("The word is: ");
            for (int i = 0; i < n; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                Console.Write(ch);
            }

            Console.WriteLine();
        }
    }
}
