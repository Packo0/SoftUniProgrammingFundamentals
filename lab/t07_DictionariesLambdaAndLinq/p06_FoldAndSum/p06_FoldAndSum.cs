using System;
using System.Linq;

namespace p06_FoldAndSum
{
    class p06_FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = numbers.Length / 4;

            var left = numbers.Take(k).Reverse().ToArray();
            var right = numbers.Reverse().Take(k).ToArray();
            var row1 = left.Concat(right);
            var row2 = numbers.Skip(k).Take(2 * k).ToArray();

            var sumArr = row1.Select((x, index) => x + row2[index]);

            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
