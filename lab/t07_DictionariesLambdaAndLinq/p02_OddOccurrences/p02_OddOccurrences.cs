using System;
using System.Collections.Generic;

namespace p02_OddOccurrences
{
    class p02_OddOccurrences
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split();
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            List<string> oddWords = new List<string>();

            foreach (var word in words)
            {
                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word]++;
                }
                else
                {
                    wordsCount[word] = 1;
                }
            }

            foreach (var kvp in wordsCount)
            {
                if (kvp.Value % 2 != 0)
                {
                    oddWords.Add(kvp.Key);
                }
            }

            Console.WriteLine(string.Join(", ", oddWords));
        }
    }
}
