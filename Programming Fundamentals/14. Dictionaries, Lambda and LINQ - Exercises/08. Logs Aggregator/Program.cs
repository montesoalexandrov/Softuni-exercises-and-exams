using System;
using System.Collections.Generic;
using System.Linq;

class Logs_Aggregator
{
    static void Main(string[] args)
    {
        var namesIpsDurations =
            new SortedDictionary<string, SortedDictionary<string, int>>();
        var count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            var input = Console.ReadLine().Split();
            var name = input[1];
            var ip = input[0];
            var duration = int.Parse(input[2]);
            if (!namesIpsDurations.ContainsKey(name))
            {
                namesIpsDurations[name] = new SortedDictionary<string, int>();
            }

            if (!namesIpsDurations[name].ContainsKey(ip))
            {
                namesIpsDurations[name][ip] = 0;
            }
            namesIpsDurations[name][ip] += duration;
        }
        foreach (var nameIpDurations in namesIpsDurations)
        {
            var name = nameIpDurations.Key;
            var ipsDuration = nameIpDurations.Value;
            var totalDuration = ipsDuration.Sum(a => a.Value);
            var ips = ipsDuration.Select(a => a.Key).ToArray();
            Console.WriteLine($"{name}: {totalDuration} [{string.Join(", ", ips)}]");
        }
    }
}