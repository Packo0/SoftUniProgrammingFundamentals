using System;
using System.Collections.Generic;
using System.Linq;

namespace p05_HandsOfCards
{
    class p05_HandsOfCards
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> peopleScores = new Dictionary<string, List<string>>();            

            while (command != "JOKER")
            {
                string[] commandArgs = command.Split(':');//.Select(x => x.Trim()).ToArray();

                string name = commandArgs[0];
                string[] cards = commandArgs[1].Trim().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                if (!peopleScores.ContainsKey(name))
                {
                    peopleScores.Add(name, new List<string>());

                    foreach (var card in cards)
                    {
                        peopleScores[name].Add(card);
                    }
                }
                else
                {
                    foreach (var card in cards)
                    {
                        peopleScores[name].Add(card);
                    }
                }

                peopleScores[name] = peopleScores[name].Distinct().ToList();

                command = Console.ReadLine();
            }

            foreach (var pair in peopleScores)
            {
                string name = pair.Key;
                int sum = CalcPersonScore(peopleScores[name]);

                Console.WriteLine($"{name}: {sum}");
            }
        }

        private static int CalcPersonScore(List<string> cards)
        {
            int sum = 0;

            foreach (var card in cards)
            {
                char powers = card[0];
                char types = card[card.Length - 1];
                int power = 0;
                switch (powers)
                {
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        power = powers - '0';
                        break;
                    case '1':
                        power = 10;
                        break;
                    case 'J':
                        power = 11;
                        break;
                    case 'Q':
                        power = 12;
                        break;
                    case 'K':
                        power = 13;
                        break;
                    case 'A':
                        power = 14;
                        break;
                    default:
                        break;
                }

                int type = 0;
                switch (types)
                {
                    case 'S':
                        type = 4;
                        break;
                    case 'H':
                        type = 3;
                        break;
                    case 'D':
                        type = 2;
                        break;
                    case 'C':
                        type = 1;
                        break;
                    default:
                        break;
                }
                sum += power * type;
            }

            return sum;
        }
    }
}
