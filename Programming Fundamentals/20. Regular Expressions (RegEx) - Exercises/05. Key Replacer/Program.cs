using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split(new char[] { '<', '|', '\\'}).ToArray();
            string start = commands[0];
            string end = commands[2];

            string input = Console.ReadLine();
            string pattern = $@"{start}(.*?){end}";

            MatchCollection words = Regex.Matches(input, pattern);
            
            string result = String.Empty;

            foreach (Match word in words)
            {
                result += word.Groups[1];
            }
            if (result == "")
            {
                Console.Write("Empty result");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}