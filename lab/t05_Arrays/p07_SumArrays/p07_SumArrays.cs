using System;
using System.Linq;

namespace p07_SumArrays
{
    class p07_SumArrays
    {
        static void Main(string[] args)
        {
            var array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int max = Math.Max(array1.Length, array2.Length);

            var sum = new int[max];
            for (int i = 0; i < max; i++)
            {
                sum[i] = array1[i % array1.Length] + array2[i % array2.Length];
            }

            Console.WriteLine(string.Join(" ", sum));

        }
    }
}
