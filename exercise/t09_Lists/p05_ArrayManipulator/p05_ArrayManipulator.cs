using System;
using System.Collections.Generic;
using System.Linq;

namespace p05_ArrayManipulator
{
    class p05_ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split(' ');

            while (command[0] != "print")
            {
                if (command[0] == "add")
                {
                    int index = int.Parse(command[1]);
                    int element = int.Parse(command[2]);
                    numbers.Insert(index, element);
                }
                else if (command[0] == "addMany")
                {
                    int index = int.Parse(command[1]);
                    List<int> elements = new List<int>();
                    for (int i = 2; i < command.Length; i++)
                    {
                        elements.Add(int.Parse(command[i]));
                    }

                    numbers.InsertRange(index, elements);
                }
                else if (command[0] == "contains")
                {
                    int element = int.Parse(command[1]);
                    Console.WriteLine(numbers.IndexOf(element));
                }
                else if (command[0] == "remove")
                {
                    int index = int.Parse(command[1]);
                    numbers.RemoveAt(index);
                }
                else if (command[0] == "shift")
                {
                    int positions = int.Parse(command[1]);
                    for (int i = 0; i < positions; i++)
                    {
                        var temp = numbers[0];
                        for (var j = 0; j < numbers.Count - 1; j++)
                        {
                            numbers[j] = numbers[j + 1];
                        }

                        numbers[numbers.Count - 1] = temp;
                    }
                }
                else if (command[0] == "sumPairs")
                {
                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        numbers[i] = numbers[i] + numbers[i + 1];
                        numbers.RemoveAt(i + 1);
                    }
                }

                command = Console.ReadLine().Split(' ');
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}
