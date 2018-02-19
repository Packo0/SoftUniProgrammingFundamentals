using System;

namespace p14_IntegerToHexAndBinary
{
    class p14_IntegerToHexAndBinary
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string numberInHex = Convert.ToString(number, 16).ToUpper();
            Console.WriteLine(numberInHex);

            string numberInBinary = Convert.ToString(number, 2);
            Console.WriteLine(numberInBinary);
        }
    }
}
