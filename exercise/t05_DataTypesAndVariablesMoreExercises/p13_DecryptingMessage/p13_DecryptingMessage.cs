using System;

namespace p13_DecryptingMessage
{
    class p13_DecryptingMessage
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string message = string.Empty;
            for (int i = 0; i < n; i++)
            {
                char current = char.Parse(Console.ReadLine());

                message += (char)(current + key);
            }

            Console.WriteLine(message);
        }
    }
}
