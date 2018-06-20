using System;
using System.Collections.Generic;
using System.Linq;

public class Population_Counter
{
    public static void Main()
    {
        var dict = new Dictionary<string, Dictionary<string, long>>();
        var input = Console.ReadLine().Split('|').ToArray();
        while (input[0] != "report")
        {
            var country = input[1];
            var city = input[0];
            var population = long.Parse(input[2]);
            if (!dict.ContainsKey(country))
            {
                dict[country] = new Dictionary<string, long>();
            }
            dict[country][city] = population;
            input = Console.ReadLine().Split('|').ToArray();
        }

        foreach (var printCountries in dict.OrderByDescending(x => (x.Value.Values.Sum())))
        {
            var country = printCountries.Key;
            Console.WriteLine($"{country} (total population: {(printCountries.Value.Values.Sum())})");
            foreach (var printCities in printCountries.Value.OrderByDescending(x => x.Value))
            {
                var city = printCities.Key;
                Console.WriteLine($"=>{city}: {printCities.Value}");
            }
        }
    }
}