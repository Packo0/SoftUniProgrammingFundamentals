using System;
using System.Collections.Generic;

namespace p01_Phonebook
{
    class p01_Phonebook
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, string> peoplePhones = new Dictionary<string, string>();

            while (command != "END")
            {
                string[] commandArgs = command.Split(' ');
                string name = commandArgs[1];

                if (commandArgs[0] == "A")
                {
                    string phone = commandArgs[2];
                    peoplePhones[name] = phone;
                }
                else if (commandArgs[0] == "S")
                {
                    if (peoplePhones.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {peoplePhones[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
