namespace FootballTeamGenerator
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Team
    {
        private string name;
        private List<Player> players;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }

        public List<Player> Players
        {
            get { return players; }
            set { players = value; }
        }

        public Team(string name)
        {
            this.name = name;
            players = new List<Player>();
        }

        public int GetRating()
        {
            if (players.Count == 0)
            {
                return 0;
            }
            return (int)Math.Round(this.players.Select(p => p.GetAverageRating()).Sum() / (double)players.Count);
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            bool containsPlayer = this.players.Any(p => p.Name == playerName);
            if (!containsPlayer)
            {
                throw new ArgumentException(string.Format($"Player {playerName} is not in {Name} team."));
            }
            Player player = this.players.Where(p => p.Name == playerName).First();
            players.Remove(player);
        }
    }
}