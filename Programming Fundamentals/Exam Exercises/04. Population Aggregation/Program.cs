using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Population_Aggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            var citiesCountByCountry = new SortedDictionary<string, int>();
            var populationByCity = new Dictionary<string, long>();

            while (true)
            {
                var input = Console.ReadLine();

                string country = string.Empty;
                string city = string.Empty;

                if (input == "stop")
                {
                    break;
                }

                var tokens = input.Split('\\').ToArray();

                int population = int.Parse(tokens[2]);

                if (char.IsUpper(tokens[0][0]))
                {
                    country = tokens[0];
                    city = tokens[1];
                }
                else
                {
                    country = tokens[1];
                    city = tokens[0];
                }

                country = country.Replace("@", string.Empty);
                country = country.Replace("#", string.Empty);
                country = country.Replace("$", string.Empty);
                country = country.Replace("&", string.Empty);
                country = country.Replace("0", string.Empty);
                country = country.Replace("1", string.Empty);
                country = country.Replace("2", string.Empty);
                country = country.Replace("3", string.Empty);
                country = country.Replace("4", string.Empty);
                country = country.Replace("5", string.Empty);
                country = country.Replace("6", string.Empty);
                country = country.Replace("7", string.Empty);
                country = country.Replace("8", string.Empty);
                country = country.Replace("9", string.Empty);

                city = city.Replace("@", string.Empty);
                city = city.Replace("#", string.Empty);
                city = city.Replace("$", string.Empty);
                city = city.Replace("&", string.Empty);
                city = city.Replace("0", string.Empty);
                city = city.Replace("1", string.Empty);
                city = city.Replace("2", string.Empty);
                city = city.Replace("3", string.Empty);
                city = city.Replace("4", string.Empty);
                city = city.Replace("5", string.Empty);
                city = city.Replace("6", string.Empty);
                city = city.Replace("7", string.Empty);
                city = city.Replace("8", string.Empty);
                city = city.Replace("9", string.Empty);

                if (!citiesCountByCountry.ContainsKey(country))
                {
                    citiesCountByCountry[country] = 0;
                }
                citiesCountByCountry[country]++;
                populationByCity[city] = long.Parse(tokens[2]);
            }
            foreach (var country in citiesCountByCountry)
            {
                Console.WriteLine($"{country.Key} -> {country.Value}");
            }
            foreach (var city in populationByCity.OrderByDescending(a => a.Value).Take(3))
            {
                Console.WriteLine($"{city.Key} -> {city.Value}");
            }
        }
    }
}