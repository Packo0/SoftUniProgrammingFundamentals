using System;
using System.Collections.Generic;

namespace p02_PhonebookUpgrade
{
    class p02_PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            SortedDictionary<string, string> peoplePhones = new SortedDictionary<string, string>();

            while (command != "END")
            {
                string[] commandArgs = command.Split(' ');
                
                if (commandArgs[0] == "A")
                {
                    string name = commandArgs[1];
                    string phone = commandArgs[2];
                    peoplePhones[name] = phone;
                }
                else if (commandArgs[0] == "S")
                {
                    string name = commandArgs[1];

                    if (peoplePhones.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {peoplePhones[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else if (command == "ListAll")
                {
                    foreach (var kvp in peoplePhones)
                    {
                        Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
