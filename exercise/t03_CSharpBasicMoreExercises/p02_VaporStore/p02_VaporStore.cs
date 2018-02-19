using System;

namespace p02_VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialBalance = double.Parse(Console.ReadLine());
            double currentBalance = initialBalance;
            string game = Console.ReadLine();
            double moneySpent = 0;
            while (game != "Game Time")
            {

                if (game == "OutFall 4")
                {
                    currentBalance -= 39.99;
                    if (currentBalance < 0)
                    {
                        currentBalance += 39.99;
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        moneySpent += 39.99;
                        Console.WriteLine($"Bought {game}");
                    }
                }
                else if (game == "CS: OG")
                {
                    currentBalance -= 15.99;
                    if (currentBalance < 0)
                    {
                        currentBalance += 15.99;
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        moneySpent += 15.99;
                        Console.WriteLine($"Bought {game}");
                    }
                }
                else if (game == "Zplinter Zell")
                {
                    currentBalance -= 19.99;
                    if (currentBalance < 0)
                    {
                        currentBalance += 19.99;
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        moneySpent += 19.99;
                        Console.WriteLine($"Bought {game}");
                    }
                }
                else if (game == "Honored 2")
                {
                    currentBalance -= 59.99;
                    if (currentBalance < 0)
                    {
                        currentBalance += 59.99;
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        moneySpent += 59.99;
                        Console.WriteLine($"Bought {game}");
                    }
                }
                else if (game == "RoverWatch")
                {
                    currentBalance -= 29.99;
                    if (currentBalance < 0)
                    {
                        currentBalance += 29.99;
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        moneySpent += 29.99;
                        Console.WriteLine($"Bought {game}");
                    }
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    currentBalance -= 39.99;
                    if (currentBalance < 0)
                    {
                        currentBalance += 39.99;
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        moneySpent += 39.99;
                        Console.WriteLine($"Bought {game}");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                game = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${moneySpent:F2}. Remaining: ${(initialBalance - moneySpent):F2}");
        }
    }
}
