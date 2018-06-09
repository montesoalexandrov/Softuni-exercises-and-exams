using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            var numbers = Regex.Matches(input, pattern).Cast<Match>().Select(a => a.Value).ToArray();
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}