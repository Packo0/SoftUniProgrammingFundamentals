using System;
using System.Linq;
namespace p06_SumReversedNumbers
{
    class p06_SumReversedNumbers
    {
        static void Main(string[] args)
        {
            long result = Console.ReadLine().Split(' ')
                .Select(a => int.Parse(new string(a.Reverse().ToArray())))
                .Sum();

            Console.WriteLine(result);            
        }
    }
}
