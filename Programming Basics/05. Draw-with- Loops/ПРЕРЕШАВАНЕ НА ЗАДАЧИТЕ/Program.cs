using System;

namespace ПРЕРЕШАВАНЕ_НА_ЗАДАЧИТЕ
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', n - i - 1));
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for (int i = n - 2; i >= 0; i--)
            {
                Console.Write(new string(' ', n - i - 1 ));
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}