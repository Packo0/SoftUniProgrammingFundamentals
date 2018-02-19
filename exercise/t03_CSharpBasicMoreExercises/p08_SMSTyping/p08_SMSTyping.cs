using System;

namespace p08_SMSTyping
{
    class p08_SMSTyping
    {
        static void Main(string[] args)
        {
            int characters = int.Parse(Console.ReadLine());

            for (int i = 0; i < characters; i++)
            {
                string number = Console.ReadLine();

                if (number == "0")
                {
                    Console.Write(" ");
                }

                if (number[0] == '2')
                {
                    switch (number.Length)
                    {
                        case 1: Console.Write("a"); break;
                        case 2: Console.Write("b"); break;
                        case 3: Console.Write("c"); break;
                    }
                }

                if (number[0] == '3')
                {
                    switch (number.Length)
                    {
                        case 1: Console.Write("d"); break;
                        case 2: Console.Write("e"); break;
                        case 3: Console.Write("f"); break;
                    }
                }

                if (number[0] == '4')
                {
                    switch (number.Length)
                    {
                        case 1: Console.Write("g"); break;
                        case 2: Console.Write("h"); break;
                        case 3: Console.Write("i"); break;
                    }
                }

                if (number[0] == '5')
                {
                    switch (number.Length)
                    {
                        case 1: Console.Write("j"); break;
                        case 2: Console.Write("k"); break;
                        case 3: Console.Write("l"); break;
                    }
                }

                if (number[0] == '6')
                {
                    switch (number.Length)
                    {
                        case 1: Console.Write("m"); break;
                        case 2: Console.Write("n"); break;
                        case 3: Console.Write("o"); break;
                    }
                }

                if (number[0] == '7')
                {
                    switch (number.Length)
                    {
                        case 1: Console.Write("p"); break;
                        case 2: Console.Write("q"); break;
                        case 3: Console.Write("r"); break;
                        case 4: Console.Write("s"); break;
                    }
                }

                if (number[0] == '8')
                {
                    switch (number.Length)
                    {
                        case 1: Console.Write("t"); break;
                        case 2: Console.Write("u"); break;
                        case 3: Console.Write("v"); break;
                    }
                }

                if (number[0] == '9')
                {
                    switch (number.Length)
                    {
                        case 1: Console.Write("w"); break;
                        case 2: Console.Write("z"); break;
                        case 3: Console.Write("y"); break;
                        case 4: Console.Write("z"); break;
                    }
                }
            }
        }
    }
}
