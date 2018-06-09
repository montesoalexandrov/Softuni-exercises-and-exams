using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            var dwarfs = new Dictionary<string, int>();
            var colors = new Dictionary<string, int>();

            string line;
            while((line = Console.ReadLine()) != "Once upon a time")
            {
                string[] tokens = line.Split(new[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries);

                string dwarfName = tokens[0];
                string dwarfHatColor = tokens[1];
                int dwarfPhysics = int.Parse(tokens[2]);

                if (colors.ContainsKey(dwarfHatColor) == false)
                {
                    colors.Add(dwarfHatColor, 1);
                }
                else
                {
                    colors[dwarfHatColor]++;
                }

                string currentDwarfId = $"{dwarfName} <:> {dwarfHatColor}";

                if (dwarfs.ContainsKey(currentDwarfId) == false)
                {
                    dwarfs.Add(currentDwarfId, dwarfPhysics);
                }
                else
                {
                    int oldValue = dwarfs[currentDwarfId];

                    if (dwarfPhysics > oldValue)
                    {
                        dwarfs[currentDwarfId] = dwarfPhysics;
                    }
                }
            }

            var sortedDwarfs = dwarfs
                .OrderByDescending(d => d.Value)
                .ThenByDescending(d => colors[d.Key.Split(new[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries)[1]])
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var dwarf in sortedDwarfs)
            {
                string dwarfId = dwarf.Key;
                string[] dwarfIdTokens = dwarfId.Split(new[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries);
                string dwarfName = dwarfIdTokens[0];
                string dwarfHatColor = dwarfIdTokens[1];
                int dwarfPhysics = dwarf.Value;

                Console.WriteLine($"({dwarfHatColor}) {dwarfName} <-> {dwarfPhysics}");
            }
        }
    }
}