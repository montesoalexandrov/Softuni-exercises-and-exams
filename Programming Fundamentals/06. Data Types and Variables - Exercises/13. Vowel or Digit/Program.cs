﻿using System;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            if (symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u')
            { Console.WriteLine("vowel"); }
            else if (char.IsNumber(symbol))
            { Console.WriteLine("digit"); }
            else
            { Console.WriteLine("other"); }
        }
    }
}
