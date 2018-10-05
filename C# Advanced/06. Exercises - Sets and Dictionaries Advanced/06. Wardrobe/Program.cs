using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new Dictionary<string, Dictionary<string, int>>();

            int numberOfLines = int.Parse(Console.ReadLine());

            for (int counter = 0; counter < numberOfLines; counter++)
            {
                var input = Console.ReadLine();
                var tokens = input.Split(" -> ");
                var color = tokens[0];
                string[] clothes = tokens[1].Split(',');

                if (!colors.ContainsKey(color))
                {
                    colors.Add(color, new Dictionary<string, int>());
                }

                foreach (var c in clothes)
                {
                    if (colors[color].ContainsKey(c))
                    {
                        colors[color][c]++;
                    }
                    else
                    {
                        colors[color].Add(c, 1);
                    }
                }
            }

            var searchedInput = Console.ReadLine().Split();
            var searchedColor = searchedInput[0];
            var searchedClothes = searchedInput[1];

            foreach (var color in colors)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var c in color.Value)
                {
                    if (color.Key == searchedColor && c.Key == searchedClothes)
                    {
                        Console.WriteLine($"* {c.Key} - {c.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {c.Key} - {c.Value}");
                    }
                }
            }
        }
    }
}