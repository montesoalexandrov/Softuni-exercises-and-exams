using System;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] letters = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                letters[i] = word[i];
            }
            foreach (char index in letters)
            {
                Console.WriteLine($"{index} -> {(int)index - 97}");
            }
        }
    }
}