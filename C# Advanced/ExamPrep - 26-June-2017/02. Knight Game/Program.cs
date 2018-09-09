using System;

namespace _02._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int boardSize = int.Parse(Console.ReadLine());
            char[][] board = new char[boardSize][];
            for (int counter = 0; counter < boardSize; counter++)
            {
                board[counter] = Console.ReadLine().ToCharArray();
            }

            int maxRow = 0;
            int maxCol = 0;
            int maxAtteckedPositions = 0;
            int countOfRemoveKnights = 0;

            do
            {
                if (maxAtteckedPositions > 0)
                {
                    board[maxRow][maxCol] = '0';
                    maxAtteckedPositions = 0;
                    countOfRemoveKnights++;
                }

                int currentAttackPosition = 0;

                for (int row = 0; row < boardSize; row++)
                {
                    for (int col = 0; col < boardSize; col++)
                    {
                        if (board[row][col] == 'K')
                        {
                            currentAttackPosition = CalculateAttackedPositions(row, col, board);

                            if (currentAttackPosition > maxAtteckedPositions)
                            {
                                maxAtteckedPositions = currentAttackPosition;
                                maxRow = row;
                                maxCol = col;
                            }
                        }
                    }
                }
            }
            while (maxAtteckedPositions > 0);

            Console.WriteLine(countOfRemoveKnights);
        }

        static int CalculateAttackedPositions(int row, int col, char[][] board)
        {
            var currentAttackPosition = 0;

            if (IsPositionAttacked(row - 2, col - 1, board))
            {
                currentAttackPosition++;
            }
            if (IsPositionAttacked(row - 2, col + 1, board))
            {
                currentAttackPosition++;
            }
            if (IsPositionAttacked(row - 1, col - 2, board))
            {
                currentAttackPosition++;
            }
            if (IsPositionAttacked(row - 1, col + 2, board))
            {
                currentAttackPosition++;
            }
            if (IsPositionAttacked(row + 1, col - 2, board))
            {
                currentAttackPosition++;
            }
            if (IsPositionAttacked(row + 1, col + 2, board))
            {
                currentAttackPosition++;
            }
            if (IsPositionAttacked(row + 2, col - 1, board))
            {
                currentAttackPosition++;
            }
            if (IsPositionAttacked(row + 2, col + 1, board))
            {
                currentAttackPosition++;
            }

            return currentAttackPosition;
        }

        static bool IsPositionAttacked(int row, int col, char[][] board)
        {
            return isPositionWithinBoard(row, col, board[0].Length) && board[row][col] == 'K';
        }

        static bool isPositionWithinBoard(int row, int col, int boardSize)
        {
            return row >= 0 && row < boardSize && col >= 0 && col < boardSize;
        }
    }
}