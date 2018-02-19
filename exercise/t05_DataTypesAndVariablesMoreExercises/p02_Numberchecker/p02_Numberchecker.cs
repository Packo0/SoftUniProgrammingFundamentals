using System;

namespace p02_Numberchecker
{
    class p02_Numberchecker
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            bool isInteger = long.TryParse(number, out long result);

            if (isInteger)
            {
                Console.WriteLine("integer");
            }
            else
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
