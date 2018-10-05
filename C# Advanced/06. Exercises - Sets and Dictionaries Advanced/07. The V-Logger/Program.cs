using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var vloggers = new List<Vlogger>();

        var input = string.Empty;

        while ((input = Console.ReadLine()) != "Statistics")
        {
            var tokens = input.Split();

            if (tokens.Length == 4)
            {
                var vlogger = new Vlogger(tokens[0]);

                if (!vloggers.Any(v => v.Name == tokens[0]))
                {
                    vloggers.Add(vlogger);
                }
            }
            else
            {
                var firstVlogger = tokens[0];
                var secondVlogger = tokens[2];

                if (firstVlogger != secondVlogger && vloggers.Any(v => v.Name == firstVlogger) && vloggers.Any(v => v.Name == secondVlogger))
                {
                    vloggers.FirstOrDefault(v => v.Name == secondVlogger).Followers.Add(firstVlogger);
                    vloggers.FirstOrDefault(v => v.Name == firstVlogger).Following.Add(secondVlogger);
                }
            }
        }

        Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

        int position = 1;

        foreach (var vlogger in vloggers.OrderByDescending(x => x.Followers.Count).ThenBy(x => x.Following.Count))
        {
            Console.WriteLine($"{position}. {vlogger.Name} : {vlogger.Followers.Count} followers, {vlogger.Following.Count} following"); ;
            if (position == 1)
            {
                foreach (var foll in vlogger.Followers.OrderByDescending(s => s.Length).ThenBy(r => r))
                {
                    Console.WriteLine($"*  {foll}");
                }
            }
            position++;
        }
    }
}

public class Vlogger
{
    public string Name { get; set; }
    public HashSet<string> Followers { get; set; }
    public HashSet<string> Following { get; set; }

    public Vlogger(string name)
    {
        this.Name = name;
        this.Followers = new HashSet<string>();
        this.Following = new HashSet<string>();
    }
}