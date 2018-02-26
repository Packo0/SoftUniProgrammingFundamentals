using System;
using System.Collections.Generic;
using System.Text;

namespace p06_UserLogs
{
    class p06_UserLogs
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            SortedDictionary<string, Dictionary<string, int>> adminLogins =
                new SortedDictionary<string, Dictionary<string, int>>();

            while (command != "end")
            {
                string[] commandArgs = command.Split(' ');
                string name = commandArgs[2].Substring(5); //commandArgs[2].Replace("user=", "");
                string ip = commandArgs[0].Substring(3);
                if (!adminLogins.ContainsKey(name))
                {
                    adminLogins.Add(name, new Dictionary<string, int>());

                    if (!adminLogins[name].ContainsKey(ip))
                    {
                        adminLogins[name].Add(ip, 1);
                    }
                    else
                    {
                        adminLogins[name][ip]++;
                    }
                }
                else
                {
                    if (!adminLogins[name].ContainsKey(ip))
                    {
                        adminLogins[name].Add(ip, 1);
                    }
                    else
                    {
                        adminLogins[name][ip]++;
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var kvp in adminLogins)
            {
                Console.WriteLine($"{kvp.Key}: ");

                StringBuilder sb = new StringBuilder();

                foreach (var ip in kvp.Value)
                {
                    sb.Append($"{ip.Key} => {ip.Value}, ");
                }

                sb.Remove(sb.Length - 2, 2);
                sb.Append(".");
                Console.WriteLine(sb.ToString());
            }
        }
    }
}
