using System;
using System.Collections.Generic;

namespace p04_FixEmails
{
    class p04_FixEmails
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> peopleEmails = new Dictionary<string, string>();
            string input = Console.ReadLine();
            string name = string.Empty;
            string email = string.Empty;

            while (input != "stop")
            {
                name = input;
                email = Console.ReadLine();

                if (!(email.ToLower().EndsWith("us") || email.ToLower().EndsWith("uk")))
                {
                    peopleEmails.Add(name, email);
                }

                input = Console.ReadLine();
            }

            foreach (var pair in peopleEmails)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
