using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Z]{2})([0-9]{2}.[0-9]{1,2})([A-Za-z]+)\|";
            string input = Console.ReadLine();
            var lines = new List<string>();

            while (input != "end")
            {
                lines.Add(input);
                input = Console.ReadLine();
            }

            var myMatches = new List<Match>();

            foreach (var line in lines)
            {
                MatchCollection matches = Regex.Matches(line, pattern);
                foreach (Match m in matches)
                {
                    myMatches.Add(m);
                }
            }
            var dict = new Dictionary<string, List<string>>();
            foreach (var match in myMatches)
            {
                var info = new List<string>();
                if (!dict.ContainsKey(match.Groups[1].Value))
                {
                    info.Add(match.Groups[2].Value);
                    info.Add(match.Groups[3].Value);
                    dict.Add(match.Groups[1].Value, info);
                }
                else
                {
                    dict.Remove(match.Groups[1].Value);
                    info.Add(match.Groups[2].Value);
                    info.Add(match.Groups[3].Value);
                    dict.Add(match.Groups[1].Value, info);
                }
            }
            foreach (var print in dict.OrderBy(a => double.Parse(a.Value[0])))
            {
                string name = print.Key;
                double temp = double.Parse(print.Value[0]);
                string weather = print.Value[1];
                Console.WriteLine($"{name} => {temp:f2} => {weather}");
            }
        }
    }
}