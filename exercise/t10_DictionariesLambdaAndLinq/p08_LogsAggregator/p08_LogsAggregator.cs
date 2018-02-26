using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p08_LogsAggregator
{
    class p08_LogsAggregator
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, SortedDictionary<string, int>> usersIps =
                new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                string ip = line[0];
                string user = line[1];
                int duration = int.Parse(line[2]);

                if (!usersIps.ContainsKey(user))
                {
                    usersIps.Add(user, new SortedDictionary<string, int>());
                    usersIps[user].Add(ip, duration);
                }
                else
                {
                    if (!usersIps[user].ContainsKey(ip))
                    {
                        usersIps[user].Add(ip, duration);
                    }
                    else
                    {
                        usersIps[user][ip] += duration;
                    }
                }
            }

            foreach (var user in usersIps)
            {
                int totalDuration = user.Value.Values.Sum();
                Console.Write($"{user.Key}: {totalDuration} ");

                StringBuilder sb = new StringBuilder();
                sb.Append("[");
                foreach (var ip in user.Value)
                {
                    sb.Append($"{ip.Key}, ");
                }

                sb.Remove(sb.Length - 2, 2);
                sb.Append("]");
                Console.WriteLine(sb.ToString());
            }
        }
    }
}
