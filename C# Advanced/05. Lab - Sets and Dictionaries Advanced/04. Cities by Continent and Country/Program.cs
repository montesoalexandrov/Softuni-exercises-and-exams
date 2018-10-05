using System;
using System.Collections.Generic;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            var continents = new Dictionary<string, Dictionary<string, string>>();

            int dataLines = int.Parse(Console.ReadLine());

            for (int counter = 0; counter < dataLines; counter++)
            {
                var input = Console.ReadLine().Split();

                var continent = input[0];
                var country = input[1];
                var city = input[2];

                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, string>());
                }

                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent].Add(country, city);
                }
                else
                {
                    continents[continent][country] += $", {city}";
                }
            }

            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    Console.Write($"{country.Key} -> ");

                    foreach (var city in country.Value)
                    {
                        Console.Write($"{city}");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}