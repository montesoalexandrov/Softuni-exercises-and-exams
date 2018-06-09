using System;
using System.Text.RegularExpressions;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(^|(?<=\s))([a-z0-9]+)([_\.-][a-z0-9]+)*@([a-z0-9])+([-.][a-z0-9]*)([a-z0-9]+)([_\.-][a-z0-9]+)*";

            MatchCollection match = Regex.Matches(input, pattern);

            foreach (Match m in match)
            {
                Console.WriteLine(m);
            }
        }
    }
}