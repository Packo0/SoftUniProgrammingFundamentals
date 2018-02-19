using System;

namespace p15_BalancedBracket
{
    class p15_BalancedBracket
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int opening = 0;
            int closing = 0;
            for (int i = 0; i < n; i++)
            {
                string current = Console.ReadLine();

                if (current == "(" && i == n - 1)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }

                if (current == "(")
                {
                    opening++;
                }
                else if(current == ")")
                {
                    closing++;
                }
            }

            if (opening == closing)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
