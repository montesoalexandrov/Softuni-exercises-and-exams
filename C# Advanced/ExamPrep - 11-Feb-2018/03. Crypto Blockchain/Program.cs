using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._Crypto_Blockchain
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            string text = string.Empty;
            var indexes = new Queue<int>();

            for (int i = 0; i < numberOfRows; i++)
            {
                string input = Console.ReadLine();
                text += input;
            }
            string pattern = @"\[\D*\d{3,}\D*\]|\{\D*\d{3,}\D*\}";
            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (var match in matches)
            {
                string index = string.Empty;
                pattern = @"\d+";
                Match indexStr = Regex.Match(match.ToString(), pattern);

                if (indexStr.Length % 3 == 0)
                {
                    foreach (char ch in indexStr.ToString())
                    {
                        index += ch;
                        if (index.Length == 3)
                        {
                            indexes.Enqueue(int.Parse(index) - match.ToString().Length);
                            index = string.Empty;
                        }
                    }
                }
            }
            string decryptedText = string.Empty;
            foreach (var index in indexes)
            {
                decryptedText += (char)index;
            }
            Console.WriteLine(decryptedText);
        }
    }
}