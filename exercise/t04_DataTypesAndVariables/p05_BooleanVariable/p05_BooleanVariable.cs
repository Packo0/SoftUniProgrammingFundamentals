using System;

namespace p05_BooleanVariable
{
    class p05_BooleanVariable
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            bool isTrue = Convert.ToBoolean(str);

            if (isTrue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
