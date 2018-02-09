using System;

namespace p01_HelloName
{
    class p01_HelloName
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintGreeting(name);
        }

        static void PrintGreeting(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
