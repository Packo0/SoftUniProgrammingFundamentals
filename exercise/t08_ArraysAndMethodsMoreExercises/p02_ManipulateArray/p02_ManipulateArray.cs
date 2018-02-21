using System;
using System.Linq;

namespace p02_ManipulateArray
{
    class p02_ManipulateArray
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ');

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split(' ');
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
                        array[index] = command[2];
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
