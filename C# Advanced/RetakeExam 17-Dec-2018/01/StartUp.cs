namespace _01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var database = new Dictionary<string, Dictionary<string, double>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 3)
                {
                    string card = tokens[0];
                    string sport = tokens[1];
                    double price = double.Parse(tokens[2]);

                    if (!database.ContainsKey(card))
                    {
                        database.Add(card, new Dictionary<string, double>());
                    }
                        if (database[card].Any(s => s.Key == sport))
                        {
                            database[card][sport] = price;
                        }
                        else
                        {
                            database[card].Add(sport, price);
                        }
                }
                else
                {
                    string card = tokens[1];

                    if (database.ContainsKey(card))
                    {
                        Console.WriteLine($"{card} is available!");
                    }
                    else
                    {
                        Console.WriteLine($"{card} is not available!");
                    }
                }
            }

            foreach (var card in database.OrderByDescending(c => c.Value.Count))
            {
                Console.WriteLine($"{card.Key}:");

                foreach (var c in card.Value.OrderBy(s => s.Key))
                {
                    Console.WriteLine($"  -{c.Key} - {c.Value:f2}");
                }
            }
        }
    }
}