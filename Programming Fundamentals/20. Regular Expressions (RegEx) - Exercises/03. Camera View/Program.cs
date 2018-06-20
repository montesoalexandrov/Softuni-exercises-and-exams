using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _03.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int toSkip = numbers[0];
            int toTake = numbers[1];

            string input = Console.ReadLine();
            string pattern = $@"\|<(\w{{{toSkip}}})(\w{{0,{toTake}}})";

            MatchCollection myMatches = Regex.Matches(input, pattern);
            var result = new List<string>();

            foreach (Match m in myMatches)
            {
                result.Add(m.Groups[2].Value);
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}