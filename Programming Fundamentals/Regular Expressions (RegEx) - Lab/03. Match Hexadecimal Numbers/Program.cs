using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\b(?:0x)?[0-9A-F]+\b";

            var numbersStr = Console.ReadLine();
            var numbers = Regex.Matches(numbersStr, pattern).Cast<Match>().Select(a => a.Value).ToArray();

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}