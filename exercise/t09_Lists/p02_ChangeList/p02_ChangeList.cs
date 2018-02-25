using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_ChangeList
{
    class List
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split(' ');

            while (true)
            {
                if (command[0] == "Odd" || command[0] == "Even")
                {
                    break;
                }

                if (command[0] == "Delete")
                {
                    int element = int.Parse(command[1]);

                    while (numbers.Remove(element))
                    {
                        numbers.Remove(element);
                    }
                }
                else if (command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int position = int.Parse(command[2]);
                    numbers.Insert(position, element);
                }

                command = Console.ReadLine().Split(' ');
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (command[0] == "Odd")
                {
                    if (numbers[i] % 2 != 0)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
                else
                {
                    if (numbers[i] % 2 == 0)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }
        }
    }
}
