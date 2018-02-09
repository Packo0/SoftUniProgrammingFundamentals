using System;

namespace p18_DifferentIntegersSize
{
    class p18_DifferentIntegersSize
    {
        static void Main(string[] args)
        {
            string numberToCheck = Console.ReadLine();
            string result = string.Empty;

            try
            {
                sbyte number = sbyte.Parse(numberToCheck);

                result += "* sbyte\n";
            }
            catch
            {
            }

            try
            {
                byte number = byte.Parse(numberToCheck);

                result += "* byte\n";
            }
            catch
            {
            }

            try
            {
                short number = short.Parse(numberToCheck);

                result += "* short\n";
            }
            catch
            {
            }

            try
            {
                ushort number = ushort.Parse(numberToCheck);

                result += "* ushort\n";
            }
            catch
            {
            }

            try
            {
                int number = int.Parse(numberToCheck);

                result += "* int\n";
            }
            catch
            {
            }

            try
            {
                uint number = uint.Parse(numberToCheck);

                result += "* uint\n";
            }
            catch
            {
            }

            try
            {
                long number = long.Parse(numberToCheck);

                result += "* long\n";
            }
            catch
            {
            }

            if (string.IsNullOrEmpty(result))
            {
                Console.WriteLine($"{numberToCheck} can't fit in any type");
            }
            else
            {
                Console.WriteLine($"{numberToCheck} can fit in:\n{result}");
            }
        }
    }
}
