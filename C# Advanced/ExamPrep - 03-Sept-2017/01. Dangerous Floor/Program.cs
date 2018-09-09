using System;
using System.Linq;

namespace _01._Dangerous_Floor
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] board = new char[8][];

            for (int counter = 0; counter < 8; counter++)
            {
                board[counter] = Console.ReadLine().Split(',').Select(char.Parse).ToArray();
            }

            var input = "";
            while ((input = Console.ReadLine()) != "END")
            {
                char figure = input[0];
                int startRow = (int)Char.GetNumericValue(input[1]);
                int startCol = (int)Char.GetNumericValue(input[2]);
                int endRow = (int)Char.GetNumericValue(input[4]);
                int endCol = (int)Char.GetNumericValue(input[5]);

                if (board[startRow][startCol] != figure)
                {
                    Console.WriteLine("There is no such a piece!");
                }
                else if (!IsValidMove(startRow, startCol, endRow, endCol, figure))
                {
                    Console.WriteLine("Invalid move!");
                }
                else if (endRow < 0 || endRow > 7 || endCol < 0 || endCol > 7)
                {
                    Console.WriteLine("Move go out of board!");
                }
                else
                {
                    board[startRow][startCol] = 'x';
                    board[endRow][endCol] = figure;
                }
            }
        }

        static bool IsValidMove(int startRow, int startCol, int endRow, int endCol, char figure)
        {
            switch (figure)
            {
                case 'K':
                    return Math.Max(Math.Abs(endRow - startRow), Math.Abs(endCol - startCol)) == 1;
                case 'B':
                    return Math.Abs(endRow - startRow) == Math.Abs(endCol - startCol);
                case 'R':
                    return startRow == endRow || startCol == endCol;
                case 'Q':
                    return Math.Abs(endRow - startRow) == Math.Abs(endCol - startCol) || (startRow == endRow || startCol == endCol);
                case 'P':
                    return startCol == endCol && startRow == endRow + 1;
                default:
                    throw new ArgumentException();
            }
        }
    }
}