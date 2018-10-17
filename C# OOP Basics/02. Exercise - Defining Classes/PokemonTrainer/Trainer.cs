using System.Collections.Generic;

namespace PokemonTrainer
{
    class Trainer
    {
        private string name;
        private int numberOfBadges = 0;
        private List<Pokemon> pokemons;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int NumberOfBadges
        {
            get { return numberOfBadges; }
            set { numberOfBadges = value; }
        }

        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
            set { pokemons = value; }
        }

        public Trainer(string name, int numberOfBadges, List<Pokemon> pokemons)
        {
            this.name = name;
            this.numberOfBadges = numberOfBadges;
            this.pokemons = pokemons;
        }
    }
}