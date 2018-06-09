using System;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int count = 0;

            int firstNumber = 0;
            int secondNumber = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = m; j >= n; j--)
                {
                    count++;
                    if (i + j == magicNumber)
                    {
                        firstNumber = i;
                        secondNumber = j;
                    }
                }
            }

            if (firstNumber != 0)
            {
                Console.WriteLine($"Number found! {firstNumber} + {secondNumber} = {magicNumber}");
            }

            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
            }
        }
    }
}
