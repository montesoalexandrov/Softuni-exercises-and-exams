using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace _03_RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine().ToUpper();
            string pattern = @"(\D+)(\d+)";
            Regex regex = new Regex(pattern);

            var matches = regex.Matches(line);

            StringBuilder result = new StringBuilder();
            List<char> unique = new List<char>();

            foreach (Match match in matches)
            {
                string text = match.Groups[1].Value;
                int digit = int.Parse(match.Groups[2].Value);

                for (int i = 0; i < digit; i++)
                {
                    result.Append(text);

                }

                if (digit != 0)
                {
                    unique.AddRange(text);
                }
            }
            Console.WriteLine($"Unique symbols used: {unique.Distinct().Count()}");
            Console.WriteLine(result);
        }
    }
}