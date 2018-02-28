using System;
using System.Collections.Generic;
using System.Linq;

namespace p10_SerbianUnleashed
{
    class p10_SerbianUnleashed
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            Dictionary<string, Dictionary<string, long>> concerts = new Dictionary<string, Dictionary<string, long>>();
            while (line[0] != "End")
            {
                bool isValid = IsValid(line);
                if (!IsValid(line))
                {
                    line = Console.ReadLine().Split(' ');
                    continue;
                }

                //concat singers
                List<string> singers = new List<string>();
                int venueStart = -1;
                for (int i = 0; i < line.Length; i++)
                {
                    if (!line[i].StartsWith("@"))
                    {
                        singers.Add(line[i]);
                    }
                    else
                    {
                        venueStart = i;
                        break;
                    }
                }

                string singer = string.Join(" ", singers);

                // concat venues
                List<string> places = new List<string>();               
                for (int i = venueStart; i < line.Length - 2; i++)
                {
                    places.Add(line[i]);
                }

                string venue = string.Join(" ", places);
                venue = venue.Remove(0, 1);

                long totalMoney = int.Parse(line[line.Length - 1]) * int.Parse(line[line.Length - 2]);
                //populate the dictionary
                if (!concerts.ContainsKey(venue))
                {
                    concerts.Add(venue, new Dictionary<string, long>());

                    if (!concerts[venue].ContainsKey(singer))
                    {
                        concerts[venue].Add(singer, totalMoney);
                    }
                    else
                    {
                        concerts[venue][singer] += totalMoney;
                    }
                }
                else
                {
                    if (!concerts[venue].ContainsKey(singer))
                    {
                        concerts[venue].Add(singer, totalMoney);
                    }
                    else
                    {
                        concerts[venue][singer] += totalMoney;
                    }
                }

                line = Console.ReadLine().Split(' ');
            }

            foreach (var pair in concerts)
            {
                Console.WriteLine($"{pair.Key}");

                foreach (var kvp in pair.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {kvp.Key} -> {kvp.Value}");
                }
            }
        }

        private static bool IsValid(string[] line)
        {
            int venueIndex = -1;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i].StartsWith("@"))
                {
                    venueIndex = i;
                    break;
                }
            }

            int count = 0;
            for (int i = 0; i < venueIndex; i++)
            {
                count++;
            }

            if (count < 1 || count > 3)
            {
                return false;
            }

            count = 0;
            for (int i = venueIndex; i <= venueIndex + 2; i++)
            {
                if (!int.TryParse(line[i], out int result))
                {
                    count++;
                }
            }

            if (count < 1 || count > 3)
            {
                return false;
            }

            try
            {
                int.Parse(line[line.Length - 1]);
                int.Parse(line[line.Length - 2]);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
