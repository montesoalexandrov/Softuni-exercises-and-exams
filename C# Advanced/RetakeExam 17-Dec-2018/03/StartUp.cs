namespace _03
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[][] matrix = new int[matrixSize][];

            for (int counter = 0; counter < matrixSize; counter++)
            {
                matrix[counter] = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            }

            string[] coordinates = Console.ReadLine().Split();

            foreach (var coordinate in coordinates)
            {
                string[] rowAndCol = coordinate.Split(',');
                int row = int.Parse(rowAndCol[0]);
                int col = int.Parse(rowAndCol[1]);

                if (matrix[row][col] > 0)
                {
                    int bombDamage = matrix[row][col];

                    //Check upper row
                    if (row - 1 >= 0)
                    {
                        //Check upper-left diagonal
                        if (col - 1 >= 0)
                        {
                            if (matrix[row - 1][col - 1] > 0)
                            {
                                matrix[row - 1][col - 1] -= bombDamage;
                            }
                        }

                        //upper cell
                        if (matrix[row - 1][col] > 0)
                        {
                            matrix[row - 1][col] -= bombDamage;
                        }

                        //Check upper-right diagonal
                        if (col + 1 <= matrix.Length - 1)
                        {
                            if (matrix[row - 1][col + 1] > 0)
                            {
                                matrix[row - 1][col + 1] -= bombDamage;
                            }
                        }
                    }

                    //Check current row
                    //Check left cell
                    if (col - 1 >= 0)
                    {
                        if (matrix[row][col - 1] > 0)
                        {
                            matrix[row][col - 1] -= bombDamage;
                        }
                    }

                    //current cell
                    matrix[row][col] = 0;

                    //Check right cell
                    if (col + 1 <= matrix.Length - 1)
                    {
                        if (matrix[row][col + 1] > 0)
                        {
                            matrix[row][col + 1] -= bombDamage;
                        }
                    }

                    //Check bottom row
                    if (row + 1 < matrixSize)
                    {
                        //Check bottom-left diagonal
                        if (col - 1 >= 0)
                        {
                            if (matrix[row + 1][col - 1] > 0)
                            {
                                matrix[row + 1][col - 1] -= bombDamage;
                            }
                        }

                        //bottom cell
                        if (matrix[row + 1][col] > 0)
                        {
                            matrix[row + 1][col] -= bombDamage;
                        }

                        //Check bottom-right diagonal
                        if (col + 1 <= matrix.Length - 1)
                        {
                            if (matrix[row + 1][col + 1] > 0)
                            {
                                matrix[row + 1][col + 1] -= bombDamage;
                            }
                        }
                    }
                }
            }

            Queue<int> aliveCells = new Queue<int>();

            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    if (matrix[row][col] > 0)
                    {
                        aliveCells.Enqueue(matrix[row][col]);
                    }
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells.Count}");
            Console.WriteLine($"Sum: {aliveCells.Sum()}");

            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}