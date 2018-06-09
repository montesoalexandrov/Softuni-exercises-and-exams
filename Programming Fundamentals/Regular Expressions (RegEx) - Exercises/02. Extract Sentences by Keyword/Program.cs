using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string[] input = Console.ReadLine().Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string pattern = $@"\b{word}\b";

            for (int i = 0; i < input.Length; i++)
            {
                if (Regex.IsMatch(input[i], pattern))
                {
                    Console.WriteLine(input[i].Trim());
                }
            }
        }
    }
}