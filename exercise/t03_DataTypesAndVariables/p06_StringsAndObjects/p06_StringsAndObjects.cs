using System;

namespace p06_StringsAndObjects
{
    class p06_StringsAndObjects
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            object obj = str1 + " " + str2;

            string result = obj.ToString();

            Console.WriteLine(result);
        }
    }
}
