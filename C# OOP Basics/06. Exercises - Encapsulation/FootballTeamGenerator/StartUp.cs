namespace FootballTeamGenerator
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            string command = String.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] tokens = command.Split(';');
                switch (tokens[0])
                {
                    case "Team":
                        teams.Add(new Team(tokens[1]));
                        break;
                    case "Add":
                        string teamName = tokens[1];
                        string playerName = tokens[2];
                        int endurance = int.Parse(tokens[3]);
                        int sprint = int.Parse(tokens[4]);
                        int dribble = int.Parse(tokens[5]);
                        int passing = int.Parse(tokens[6]);
                        int shooting = int.Parse(tokens[7]);

                        bool teamExists = teams.Any(t => t.Name == teamName);
                        Team team;
                        if (!teamExists)
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }
                        else
                        {
                            try
                            {
                                team = teams.Where(t => t.Name == teamName).First();
                                Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                                team.AddPlayer(player);
                            }
                            catch (ArgumentException ArgEx)
                            {
                                Console.WriteLine(ArgEx.Message);
                            }
                        }
                        break;
                    case "Remove":
                        teamName = tokens[1];
                        team = teams.Where(t => t.Name == teamName).First();
                        playerName = tokens[2];
                        try
                        {
                            team.RemovePlayer(playerName);
                        }
                        catch (ArgumentException ArgEx)
                        {
                            Console.WriteLine(ArgEx.Message);
                        }
                        break;
                    case "Rating":
                        teamName = tokens[1];
                        teamExists = teams.Any(t => t.Name == teamName);
                        if (!teamExists)
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }
                        else
                        {
                            team = teams.Where(t => t.Name == teamName).First();
                            Console.WriteLine($"{team.Name} - {team.GetRating()}");
                        }
                        break;
                }
            }
        }
    }
}