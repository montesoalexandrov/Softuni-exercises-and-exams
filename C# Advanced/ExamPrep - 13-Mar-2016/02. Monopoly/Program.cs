using System;
using System.Linq;

namespace _02._Monopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split().Select(int.Parse).ToArray();

            char[,] gameField = new char[rowsAndCols[0], rowsAndCols[1]];
            int money = 50;
            int turns = 0;
            bool buyHotel = false;
            int hotelsCount = 0;
            int amount = 0;

            InitializeGameField(gameField);
            RotateTurns(gameField, ref money, ref turns, ref buyHotel, ref hotelsCount, ref amount);
            PrintResult(money, turns);
        }

        private static void RotateTurns(char[,] gameField, ref int money, ref int turns, ref bool buyHotel, ref int hotelsCount, ref int amount)
        {
            for (int row = 0; row < gameField.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < gameField.GetLength(1); col++)
                    {
                        char currentCell = gameField[row, col];
                        ExecuteCommands(ref money, ref buyHotel, ref hotelsCount, row, col, currentCell, ref turns, ref amount);
                    }
                }
                else
                {
                    for (int col = gameField.GetLength(1) - 1; col >= 0; col--)
                    {
                        char currentCell = gameField[row, col];
                        ExecuteCommands(ref money, ref buyHotel, ref hotelsCount, row, col, currentCell, ref turns, ref amount);
                    }
                }
            }
        }

        private static void InitializeGameField(char[,] gameField)
        {
            for (int row = 0; row < gameField.GetLength(0); row++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                for (int col = 0; col < gameField.GetLength(1); col++)
                {
                    gameField[row, col] = line[col];
                }
            }
        }

        private static void ExecuteCommands(ref int money, ref bool buyHotel, ref int hotelsCount, int row, int col, char currentCell, ref int turns, ref int amount)
        {
            switch (currentCell)
            {
                case 'H':
                        buyHotel = true;
                        hotelsCount++;
                        turns++;
                        Console.WriteLine($"Bought a hotel for {money}. Total hotels: {hotelsCount}.");
                    money = 10 * hotelsCount;
                    break;

                case 'J':
                    Console.WriteLine($"Gone to jail at turn {turns}.");
                    turns += 3;
                    money += hotelsCount * 10 * 3;
                    break;

                case 'S':
                    amount = (row + 1) * (col + 1);

                    if (money < amount)
                    {
                        Console.WriteLine($"Spent {money} money at the shop.");
                        money = 0;
                    }
                    else
                    {
                        money -= amount;
                        Console.WriteLine($"Spent {amount} money at the shop.");
                    }
                    turns++;
                    money = GetRent(money, buyHotel, hotelsCount);
                    break;

                case 'F':
                    turns++;
                    money = GetRent(money, buyHotel, hotelsCount);
                    break;
            }
        }

        private static int GetRent(int money, bool buyHotel, int hotelsCount)
        {
            if (buyHotel == true)
            {
                money += 10 * hotelsCount;
            }

            return money;
        }

        private static void PrintResult(int money, int turns)
        {
            Console.WriteLine($"Turns {turns}");
            Console.WriteLine($"Money {money}");
        }
    }
}