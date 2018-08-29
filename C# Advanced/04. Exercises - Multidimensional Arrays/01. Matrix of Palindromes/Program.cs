using System;
using System.Linq;

namespace _01._Matrix_of_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowsAndColumns = Console.ReadLine()
                .Trim()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int startIndex = 97;

            string[,] matrix = new string[rowsAndColumns[0], rowsAndColumns[1]];

            for (int row = 0; row < rowsAndColumns[0]; row++)
            {
                for (int column = 0; column < rowsAndColumns[1]; column++)
                {
                    char firstAndLastLetter = Convert.ToChar(startIndex + row);
                    char middleLetter = Convert.ToChar(startIndex + row + column);

                    matrix[row, column] = $"{firstAndLastLetter}{middleLetter}{firstAndLastLetter}";
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write(matrix[row, column] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}