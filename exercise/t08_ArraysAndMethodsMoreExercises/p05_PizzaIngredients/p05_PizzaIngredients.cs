using System;

namespace p05_PizzaIngredients
{
    class p05_PizzaIngredients
    {
        static void Main(string[] args)
        {
            var ingredients = Console.ReadLine().Split(' ');
            var length = int.Parse(Console.ReadLine());
            int count = 0;
            string result = "The ingredients are: ";
            for (int i = 0; i < ingredients.Length; i++)
            {
                var current = ingredients[i];

                if (current.Length == length)
                {
                    if (count >= 10)
                    {
                        break;
                    }

                    count++;
                    result += current + ", ";
                    Console.WriteLine($"Adding {current}.");

                    
                }
            }

            if (result.EndsWith(", "))
            {
                result = result.Remove(result.Length - 2);
            }

            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.WriteLine(result + ".");
        }
    }
}
