using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Basic_Markup_Language
{
    class Program
    {
        static void Main(string[] args)
        {
            var results = new Queue<string>();
            var input = string.Empty;
            while (!(input = Console.ReadLine()).Contains("stop"))
            {
                string pattern = @"""([\w\d\s\t#@!.?,-:]+)""";
                string result = string.Empty;

                MatchCollection matches = Regex.Matches(input, pattern);

                if (matches.Count == 1)
                {
                    string text = matches[0].Groups[1].ToString();

                    if (input.Contains("inverse"))
                    {
                        foreach (char ch in text)
                        {
                            if (char.IsLower(ch))
                            {
                                result += char.ToUpper(ch);
                            }
                            else
                            {
                                result += char.ToLower(ch);
                            }
                        }
                        CheckBeforeEnqueue(results, result);
                    }
                    else
                    {
                        result = new string(text.ToCharArray().Reverse().ToArray());
                        CheckBeforeEnqueue(results, result);
                    }
                }
                else if (matches.Count > 1)
                {
                    string value = matches[0].Groups[1].ToString();
                    int repeats = int.Parse(value);
                    string text = matches[1].Groups[1].ToString();
                    result = text;

                    for (int i = 0; i < repeats; i++)
                    {
                        CheckBeforeEnqueue(results, result);
                    }
                }
            }

            int counter = 1;

            foreach (var result in results)
            {
                Console.WriteLine($"{counter}. {result}");
                counter++;
            }
        }

        private static void CheckBeforeEnqueue(Queue<string> results, string result)
        {
            if (result.Length > 0)
            {
                results.Enqueue(result);
            }
        }
    }
}