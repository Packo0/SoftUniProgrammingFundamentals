﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_SplitByWordCasing
{
    class p04_SplitByWordCasing
    {
        static void Main(string[] args)
        {
            List<string> words =
                Console.ReadLine()
                .Split(@",;:.! ()""'\/[]".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();
            foreach (var word in words)
            {
                bool isAllLowerCase = true;
                bool isAllUpperrCase = true;
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLower(word[i]))
                    {
                        isAllUpperrCase = false;
                    }
                    else if (char.IsUpper(word[i]))
                    {
                        isAllLowerCase = false;
                    }
                    else
                    {
                        isAllLowerCase = false;
                        isAllUpperrCase = false;
                    }

                }
                if (isAllLowerCase)
                {
                    lowerCase.Add(word);
                }
                else if (isAllUpperrCase)
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
        }
    }
}
