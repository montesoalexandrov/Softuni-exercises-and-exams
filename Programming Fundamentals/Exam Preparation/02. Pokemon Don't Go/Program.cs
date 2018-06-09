using System;
using System.Linq;

namespace _02.Exam___Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;

            while (pokemons.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                int currentPokemon = 0;

                if (index >= 0 && index <= pokemons.Count - 1)
                {
                    currentPokemon = pokemons[index];
                    pokemons.RemoveAt(index);
                    sum += currentPokemon;
                }

                else if (index < 0)
                {
                    currentPokemon = pokemons[0];
                    pokemons[0] = pokemons[pokemons.Count - 1];
                    sum += currentPokemon;
                }
                else if (index > pokemons.Count - 1)
                {
                    currentPokemon = pokemons[pokemons.Count - 1];
                    pokemons[pokemons.Count - 1] = pokemons[0];
                    sum += currentPokemon;
                }

                for (int i = 0; i < pokemons.Count; i++)
                {
                    if (currentPokemon >= pokemons[i])
                    {
                        pokemons[i] += currentPokemon;
                    }
                    else if (currentPokemon < pokemons[i])
                    {
                        pokemons[i] -= currentPokemon;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}