using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_AppendLists
{
    class p02_AppendLists
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split('|').ToList();
            List<int> numbers = new List<int>();
            List<int> result = new List<int>();

            for (int i = items.Count - 1; i >= 0; i--)
            {
                numbers = items[i].Split(new char[] { ' ' },
                     StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse).ToList();

                result.AddRange(numbers);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
