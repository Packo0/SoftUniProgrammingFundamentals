using System;
using System.Linq;

namespace p05_ShortWordsSorted
{
    class p05_ShortWordsSorted
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(@".,:;()[]""'\/!? ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            var result = words
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .Select(w => w.ToLower())
                .Distinct();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
