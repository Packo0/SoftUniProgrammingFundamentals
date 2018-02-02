using System;

namespace p04_VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string numInHex = Console.ReadLine();
            int converted = Convert.ToInt32(numInHex, 16);

            Console.WriteLine(converted);
        }
    }
}
