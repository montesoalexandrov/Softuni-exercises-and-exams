using System;
using System.Linq;

namespace _05._Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(' ').ToArray();
            var word = text[0];
            var word2 = text[1];

            Console.WriteLine(IsExchangeable(word, word2));
        }

        static string IsExchangeable(string word, string word2)
        {
            string isExchangeable = String.Empty;
            if (word.Distinct().Count() == word2.Distinct().Count())
            {
                isExchangeable = "true";
            }
            else
            {
                isExchangeable = "false";
            }
            return isExchangeable;
        }
    }
}
