using System;
using System.Collections.Generic;
using System.Linq;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, List<String>>();

            string input;

            while (!(input = Console.ReadLine()).Equals("Lumpawaroo"))
            {
                if (input.Contains("|"))
                {
                    var tokens = input.Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

                    var forceSide = tokens[0];
                    var forceUser = tokens[1];

                    if (users.Any(p => p.Value.Contains(forceUser)))
                    {
                        continue;
                    }

                    if (!users.ContainsKey(forceSide))
                    {
                        users.Add(forceSide, new List<string>());
                    }

                    if (!users[forceSide].Contains(forceUser))
                    {
                        users[forceSide].Add(forceUser);
                    }


                }
                else if (input.Contains("->"))
                {
                    var tokens = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                    var forceUser = tokens[0];
                    var forceSide = tokens[1];

                    if (!users.Any(p => p.Value.Contains(forceUser)))
                    {
                        if (!users.ContainsKey(forceSide))
                        {
                            users.Add(forceSide, new List<string>());
                        }

                        users[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                    else
                    {
                        users.First(p => p.Value.Contains(forceUser)).Value.Remove(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");

                        if (!users.ContainsKey(forceSide))
                        {
                            users.Add(forceSide, new List<string>());
                        }
                        users[forceSide].Add(forceUser);
                    }
                }
            }
            foreach (var user in users.OrderByDescending(p => p.Value.Count).ThenBy(p => p.Key))
            {
                if (!user.Value.Any()) continue;

                Console.WriteLine($"Side: {user.Key}, Members: {user.Value.Count}");
                user.Value.OrderBy(p => p).ToList().ForEach(p => Console.WriteLine($"! {p}"));
            }
        }
    }
}