﻿using System;

namespace _06.Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= n - 1; j++)
                {
                    for (int k = 0; k <= n - 1; k++)
                    {
                        char letter1 = (char)('a' + i);
                        char letter2 = (char)('a' + j);
                        char letter3 = (char)('a' + k);

                        Console.WriteLine($"{letter1}{letter2}{letter3}");
                    }
                }
            }
        }
    }
}
