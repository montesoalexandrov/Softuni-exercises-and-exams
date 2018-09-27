using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var trainers = new List<Trainer>();
        var input = String.Empty;

        while ((input = Console.ReadLine()) != "Tournament")
        {
            var tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string trainerName = tokens[0];
            string pokemonName = tokens[1];
            string pokemonElement = tokens[2];
            int pokemonHealth = int.Parse(tokens[3]);

            var trainer = new Trainer(trainerName, 0, new List<Pokemon>());
            var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

            if (!trainers.Any(t => t.Name == trainerName))
            {
                trainers.Add(trainer);
            }

            trainers.First(t => t.Name == trainerName).Pokemons.Add(pokemon);
        }

        while ((input = Console.ReadLine()) != "End")
        {
            foreach (var trainer in trainers)
            {
                if (trainer.Pokemons.Any(p => p.Element == input))
                {
                    trainer.NumberOfBadges++;
                }
                else
                {
                    foreach (var pokemon in trainer.Pokemons)
                    {
                    pokemon.Health -= 10;

                    }

                    var deadPokemon = trainer.Pokemons.FirstOrDefault(p => p.Health <= 0);
                    if (deadPokemon != null)
                    {
                        trainer.Pokemons.Remove(deadPokemon);
                    }
                }
            }
        }

        foreach (var trainer in trainers.OrderByDescending(t => t.NumberOfBadges))
        {
            Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
        }
    }
}