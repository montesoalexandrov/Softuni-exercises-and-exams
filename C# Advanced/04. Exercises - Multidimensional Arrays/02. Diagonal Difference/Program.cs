using System;
using System.Linq;

namespace _02._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[squareSize, squareSize];

            for (int rows = 0; rows < squareSize; rows++)
            {
                var numbers = Console.ReadLine()
                    .Trim()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                for (int columns = 0; columns < squareSize; columns++)
                {
                    matrix[rows, columns] = numbers[columns];
                }
            }

            int firstSum = 0;
            int secondSum = 0;

            for (int rows = 0; rows < squareSize; rows++)
            {
                for (int columns = 0; columns < squareSize; columns++)
                {
                    if (rows == columns)
                    {
                        firstSum += matrix[rows, columns];
                        secondSum += matrix[rows, squareSize - 1 - columns];
                    }
                }
            }

            Console.WriteLine($"{Math.Abs(firstSum - secondSum)}");
        }
    }
}