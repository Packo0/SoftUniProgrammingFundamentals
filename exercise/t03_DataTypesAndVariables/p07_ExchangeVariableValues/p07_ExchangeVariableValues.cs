using System;

namespace p07_ExchangeVariableValues
{
    class p07_ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int temp = a;
            b = a;
            b = temp;

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
    }
}
