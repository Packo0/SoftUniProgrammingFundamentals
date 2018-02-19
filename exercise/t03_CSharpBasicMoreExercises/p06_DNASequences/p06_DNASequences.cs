using System;

namespace p06_DNASequences
{
    class p06_DNASequences
    {
        static void Main(string[] args)
        {
            int matchSum = int.Parse(Console.ReadLine());

            string[] letters = { "A", "C", "G", "T" };
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        string wrap = i + j + k >= matchSum ? "O" : "X";

                        Console.Write($"{wrap}{letters[i - 1]}{letters[j - 1]}{letters[k - 1]}{wrap} ");
                    } 

                    Console.WriteLine();
                }
            }
        }
    }
}
