﻿using System;

namespace _03.Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                PrintNumbers(1, i);
            }

            for (int i = n - 1; i >= 1; i--)
            {
                PrintNumbers(1, i);
            }
        }
        static void PrintNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
