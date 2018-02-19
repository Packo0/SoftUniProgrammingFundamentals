using System;

namespace p11_StringConcatenation
{
    class p11_StringConcatenation
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string evenOrOdd = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            int reminder = evenOrOdd == "even" ? 2 : 1;
            string result = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                string current = Console.ReadLine();

                if (evenOrOdd == "even")
                {
                    if (i % 2 == 0)
                    {
                        result += current;
                        result += delimiter;
                    }
                }
                else
                {
                    if (i % 2 == 1)
                    {
                        result += current;
                        result += delimiter;
                    }
                }
            }

            result = result.Remove(result.Length - 1, 1);
            Console.WriteLine(result);
        }
    }
}
