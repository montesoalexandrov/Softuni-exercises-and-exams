﻿using System;
using System.Linq;

namespace _03._Group_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var sizes = new int[3];

            foreach (var num in numbers)
            {
                sizes[Math.Abs(num % 3)]++;
            }

            int[][] jaggedArray = new int[3][];

            for (int counter = 0; counter < sizes.Length; counter++)
            {
                jaggedArray[counter] = new int[sizes[counter]];
            }

            int[] index = new int[3];

            foreach (var num in numbers)
            {
                var remainder = Math.Abs(num % 3);
                jaggedArray[remainder][index[remainder]] = num;
                index[remainder]++;
            }

            for (int rows = 0; rows < jaggedArray.Length; rows++)
            {
                for (int columns = 0; columns < jaggedArray[rows].Length; columns++)
                {
                    Console.Write(jaggedArray[rows][columns] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}