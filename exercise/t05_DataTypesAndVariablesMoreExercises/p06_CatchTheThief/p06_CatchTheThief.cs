using System;

namespace p06_CatchTheThief
{
    class p06_CatchTheThief
    {
        static void Main(string[] args)
        {
            string numeralType = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            if (numeralType == "sbyte")
            {
                sbyte max = sbyte.MinValue;
                for (int i = 0; i < n; i++)
                {
                    bool isInRange = sbyte.TryParse(Console.ReadLine(), out sbyte currentId);
                    if (isInRange && currentId >= max)
                    {
                        max = currentId;
                    }
                }

                Console.WriteLine(max); return;
            }

            if (numeralType == "int")
            {
                int max = int.MinValue;
                for (int i = 0; i < n; i++)
                {
                    bool isInRange = int.TryParse(Console.ReadLine(), out int currentId);
                    if (isInRange && currentId >= max)
                    {
                        max = currentId;
                    }
                }

                Console.WriteLine(max); return;
            }

            if (numeralType == "long")
            {
                long max = long.MinValue;
                for (int i = 0; i < n; i++)
                {
                    bool isInRange = long.TryParse(Console.ReadLine(), out long currentId);
                    if (isInRange && currentId >= max)
                    {
                        max = currentId;
                    }
                }

                Console.WriteLine(max); return;
            }
        }
    }
}
