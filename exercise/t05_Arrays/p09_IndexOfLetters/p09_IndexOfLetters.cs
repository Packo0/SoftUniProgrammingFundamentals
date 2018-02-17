using System;

namespace p09_IndexOfLetters
{
    class p09_IndexOfLetters
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            char[] alphabet = new char[26];

            char letter = 'a';
            for (int i = 0; i < 26; i++)
            {
                
                alphabet[i] = letter++;
            }

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (str[i] == alphabet[j])
                    {
                        Console.WriteLine($"{str[i]} -> {j}");
                    }
                }
            }
        }
    }
}
