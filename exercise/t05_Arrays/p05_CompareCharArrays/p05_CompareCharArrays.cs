using System;
using System.Linq;

namespace p05_CompareCharArrays
{
    class p05_CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            int len = Math.Min(arr1.Length, arr2.Length);
            bool isFirst = true;
            for (int i = 0; i < len; i++)
            {
                if (arr1[i] > arr2[i])
                {
                    isFirst = false;
                    break;
                }
            }

            if (isFirst && arr1.Length <= arr2.Length)
            {
                Console.WriteLine(string.Join("", arr1));
                Console.WriteLine(string.Join("", arr2));
            }
            else
            {
                Console.WriteLine(string.Join("", arr2));
                Console.WriteLine(string.Join("", arr1));
            }

        }
    }
}
