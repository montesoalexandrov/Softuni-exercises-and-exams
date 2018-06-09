﻿using System;

namespace _02._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            Random rand = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int firstWord = rand.Next(0, words.Length);
                int secondWord = rand.Next(0, words.Length);
                string changer = words[firstWord];
                words[firstWord] = words[secondWord];
                words[secondWord] = changer;
            }
            Console.WriteLine(string.Join("\n", words));
        }
    }
}