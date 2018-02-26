using System;
using System.Collections.Generic;
using System.Linq;

namespace p07_PopulationCounter
{
    class p07_PopulationCounter
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> countryPopulation =
                new Dictionary<string, Dictionary<string, long>>(); // country -> city -> population

            while (input != "report")
            {
                string[] splitted = input.Split('|');
                string city = splitted[0];
                string country = splitted[1];
                long population = long.Parse(splitted[2]);

                if (!countryPopulation.ContainsKey(country))
                {
                    countryPopulation.Add(country, new Dictionary<string, long>());

                    if (!countryPopulation[country].ContainsKey(city))
                    {
                        countryPopulation[country].Add(city, population);
                    }
                }
                else
                {
                    if (!countryPopulation[country].ContainsKey(city))
                    {
                        countryPopulation[country].Add(city, population);
                    }
                }
               
                input = Console.ReadLine();
            }

            foreach (var country in countryPopulation.OrderByDescending(x => x.Value.Values.Sum()))
            {
                var sum = country.Value.Values.Sum();
                Console.WriteLine($"{country.Key} (total population: {sum})");

                // Sorting
                Dictionary<string, long> sortedTowns = country.Value
                    .OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                foreach (var city in sortedTowns)
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
