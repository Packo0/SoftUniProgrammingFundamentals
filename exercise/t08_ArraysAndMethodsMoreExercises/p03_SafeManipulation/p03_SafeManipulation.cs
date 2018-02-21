using System;
using System.Linq;

namespace p03_SafeManipulation
{
    class p03_SafeManipulation
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ');
            var command = Console.ReadLine().Split(' ');

            while (command[0] != "END") { 
                switch (command[0])
                {
                    case "Distinct":
                        array = array.Distinct().ToArray();
                        break;
                    case "Reverse":
                        array = array.Reverse().ToArray();
                        break;
                    case "Replace":
                        var index = int.Parse(command[1]);
                        if (index < 0 || index > array.Length - 1)
                        {
                            Console.WriteLine("Invalid input!");
                            break;
                        }

                        array[index] = command[2];
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }

                command = Console.ReadLine().Split(' ');
            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
