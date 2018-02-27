using System;
using System.Collections.Generic;
using System.Linq;

namespace p09_LegendaryFarming
{
    class p09_LegendaryFarming
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> materialQuantity = new Dictionary<string, int>();

            while (true)
            {
                string[] line = Console.ReadLine().Split(" ");
                bool isObtained = false;
                for (int i = 0; i < line.Length; i += 2)
                {
                    int quantity = int.Parse(line[i]);
                    string material = line[i + 1].ToLower();

                    if (!materialQuantity.ContainsKey(material))
                    {
                        materialQuantity.Add(material, quantity);
                    }
                    else
                    {
                        materialQuantity[material] += quantity;
                    }

                    if (material == "shards" && materialQuantity[material] >= 250)
                    {
                        isObtained = true;
                        materialQuantity[material] -= 250;
                        Console.WriteLine("Shadowmourne obtained!");
                        break;
                    }
                    else if (material == "fragments" && materialQuantity[material] >= 250)
                    {
                        isObtained = true;
                        materialQuantity[material] -= 250;
                        Console.WriteLine("Valanyr obtained!");
                        break;
                    }
                    else if (material == "motes" && materialQuantity[material] >= 250)
                    {
                        isObtained = true;
                        materialQuantity[material] -= 250;
                        Console.WriteLine("Dragonwrath obtained!");
                        break;
                    }
                }

                if (isObtained)
                {
                    break;
                }
            }

            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();

            if (materialQuantity.ContainsKey("fragments"))
            {
                keyMaterials.Add("fragments", materialQuantity["fragments"]);
                materialQuantity.Remove("fragments");
            }
            else
            {
                keyMaterials.Add("fragments", 0);
            }

            if (materialQuantity.ContainsKey("shards"))
            {
                keyMaterials.Add("shards", materialQuantity["shards"]);
                materialQuantity.Remove("shards");
            }
            else
            {
                keyMaterials.Add("shards", 0);
            }

            if (materialQuantity.ContainsKey("motes"))
            {
                keyMaterials.Add("motes", materialQuantity["motes"]);
                materialQuantity.Remove("motes");
            }
            else
            {
                keyMaterials.Add("motes", 0);
            }

            foreach (var pair in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }

            foreach (var pair in materialQuantity.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
