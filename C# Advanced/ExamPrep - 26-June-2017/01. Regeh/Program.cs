using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Regeh
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"\[[\w\d]+<(\d+)REGEH(\d+)>[\w\d]+]";
            MatchCollection text = Regex.Matches(input, pattern);
            var numbers = new List<int>();

            foreach (Match match in text)
            {
                numbers.Add(int.Parse(match.Groups[1].Value));
                numbers.Add(int.Parse(match.Groups[2].Value));
            }

            string result = "";
            int index = 0;

            foreach (var num in numbers)
            {
                index += num;
                if (index > input.Length)
                {
                    index = 0 + num;
                }
                result += input[index];
            }

            Console.WriteLine(result);
        }
    }
}