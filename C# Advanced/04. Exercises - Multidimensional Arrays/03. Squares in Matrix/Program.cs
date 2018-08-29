using System;
using System.Linq;

namespace _03._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowsAndColumns = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[rowsAndColumns[0], rowsAndColumns[1]];

            for (int rows = 0; rows < rowsAndColumns[0]; rows++)
            {
                var letters = Console.ReadLine().Split(' ');

                for (int columns = 0; columns < rowsAndColumns[1]; columns++)
                {
                    matrix[rows, columns] = letters[columns];
                }
            }

            int counter = 0;

            for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
            {
                for (int columns = 0; columns < matrix.GetLength(1) - 1; columns++)
                {
                    if (matrix[rows, columns] == matrix[rows, columns + 1] && matrix[rows, columns] == matrix[rows + 1, columns] && matrix[rows, columns] == matrix[rows + 1, columns + 1])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}