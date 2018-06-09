using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Exam___Pokemon_Evolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemons = new Dictionary<string, List<KeyValuePair<string, int>>>();
            string[] input = Console.ReadLine()
                .Split(new char[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (input[0] != "wubbalubbadubdub")
            {
                string name = input[0];
                if (input.Length == 1)
                {
                    List<KeyValuePair<string, int>> pokemon;
                    if (pokemons.TryGetValue(name, out pokemon))
                    {
                        Console.WriteLine($"# {name}");
                        foreach (var evoluton in pokemon)
                        {
                            Console.WriteLine($"{evoluton.Key} <-> {evoluton.Value}");
                        }
                    }
                }
                else
                {
                    string evoType = input[1];
                    int evoIndex = int.Parse(input[2]);

                    try
                    {
                        pokemons.Add(name, new List<KeyValuePair<string, int>>());
                    }
                    catch (Exception) { }

                    pokemons[name].Add(new KeyValuePair<string, int>(evoType, evoIndex));
                }
                input = Console.ReadLine().Split(new char[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"# {pokemon.Key}");

                foreach (var evolution in pokemon.Value.OrderByDescending(p => p.Value))
                {
                    Console.WriteLine($"{evolution.Key} <-> {evolution.Value}");
                }
            }
        }
    }
}