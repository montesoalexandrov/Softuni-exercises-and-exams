using System;
using System.Text.RegularExpressions;

namespace _03.Exam___Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"[^a-zA-Z+-]+";//"([`~!?@#$%^&*()_=\\\/\[\]+|.,;: ''""{ }<>])+";
            string pattern2 = @"[a-zA-Z]+-[a-zA-Z]+";
            int turn = 0;

            while (input.Length != 0)
            {
                MatchCollection words = Regex.Matches(input, pattern);
                if (turn % 2 == 0)
                {
                    words = Regex.Matches(input, pattern);
                    if (words.Count == 0)
                    {
                        break;
                    }
                    input = input.Remove(0, words[0].Index);
                }
                else if (turn % 2 != 0)
                {
                    words = Regex.Matches(input, pattern2);
                    if (words.Count == 0)
                    {
                        break;
                    }
                    input = input.Remove(0, words[0].Index);
                }
                turn++;
                input = input.Remove(0, words[0].Length);
                Console.WriteLine(words[0]);
            }
        }
    }
}