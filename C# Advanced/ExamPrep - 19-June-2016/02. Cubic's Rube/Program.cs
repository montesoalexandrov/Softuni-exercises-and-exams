using System;
using System.Linq;

namespace _02._Cubic_s_Rube
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,,] matrix = new int[n, n, n];
            int fullCells = 0;
            long totalValue = 0;
            var input = String.Empty;

            while ((input = Console.ReadLine()) != "Analyze")
            {
                int[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int row = numbers[0];
                int col = numbers[1];
                int depth = numbers[2];
                int value = numbers[3];

                if (row >= 0 && row < n && col >= 0 && col < n && depth >= 0 && depth < n && value != 0)
                {
                    matrix[row, col, depth] = value;
                    fullCells++;
                    totalValue += value;
                }
            }

            Console.WriteLine(totalValue);
            Console.WriteLine(matrix.Length - fullCells);
        }
    }
}