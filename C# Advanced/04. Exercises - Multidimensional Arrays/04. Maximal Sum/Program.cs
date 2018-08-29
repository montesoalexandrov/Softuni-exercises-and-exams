using System;
using System.Linq;

namespace _04._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowsAndColumns = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[rowsAndColumns[0], rowsAndColumns[1]];

            for (int rows = 0; rows < rowsAndColumns[0]; rows++)
            {
                var numbers = Console.ReadLine()
                    .Trim()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                for (int columns = 0; columns < rowsAndColumns[1]; columns++)
                {
                    matrix[rows, columns] = numbers[columns];
                }
            }

            int sum = int.MinValue;
            var firstRow = "";
            var secondRow = "";
            var thirdRow = "";

            for (int rows = 0; rows < matrix.GetLength(0) - 2; rows++)
            {
                for (int columns = 0; columns < matrix.GetLength(1) - 2; columns++)
                {
                    int a1 = matrix[rows, columns];
                    int a2 = matrix[rows, columns + 1];
                    int a3 = matrix[rows, columns + 2];
                    int b1 = matrix[rows + 1, columns];
                    int b2 = matrix[rows + 1, columns + 1];
                    int b3 = matrix[rows + 1, columns + 2];
                    int c1 = matrix[rows + 2, columns];
                    int c2 = matrix[rows + 2, columns + 1];
                    int c3 = matrix[rows + 2, columns + 2];

                    int tempSum = a1 + a2 + a3 + b1 + b2 + b3 + c1 + c2 + c3;

                    if (tempSum > sum)
                    {
                        sum = tempSum;
                        firstRow = $"{a1} {a2} {a3}";
                        secondRow = $"{b1} {b2} {b3}";
                        thirdRow = $"{c1} {c2} {c3}";
                    }
                }
            }

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine(firstRow);
            Console.WriteLine(secondRow);
            Console.WriteLine(thirdRow);
        }
    }
}