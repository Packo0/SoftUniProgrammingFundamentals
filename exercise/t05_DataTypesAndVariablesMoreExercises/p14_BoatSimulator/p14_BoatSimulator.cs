using System;

namespace p14_BoatSimulator
{
    class p14_BoatSimulator
    {
        static void Main(string[] args)
        {
            char boat1 = char.Parse(Console.ReadLine());
            char boat2 = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int boatOneMoves = 0;
            int boatTwoMoves = 0;
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();

                if (word == "UPGRADE")
                {
                    boat1 = (char)(boat1 + 3);
                    boat2 = (char)(boat2 + 3);
                    continue;
                }

                if (i % 2 == 0)
                {
                    boatOneMoves += word.Length;
                }
                else
                {
                    boatTwoMoves += word.Length;
                }

                if (boatOneMoves >= 50 || boatTwoMoves >= 50)
                {
                    break;
                }
            }

            Console.WriteLine(boatOneMoves > boatTwoMoves ? boat1 : boat2);
        }
    }
}
