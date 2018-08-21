﻿using System;
using System.Linq;

namespace _01._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndColumns = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[rowsAndColumns[0], rowsAndColumns[1]];

            for (int rows = 0; rows < rowsAndColumns[0]; rows++)
            {
                var rowValues = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int columns = 0; columns < rowsAndColumns[1]; columns++)
                {
                    matrix[rows, columns] = rowValues[columns];
                }
            }

            int sum = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    sum += matrix[rows, columns];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}