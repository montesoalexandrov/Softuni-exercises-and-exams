using System;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            PrintHeaderFooterLine(n);
            for (int i = 0; i < n - 2; i++)
            {
                PrintBodyLine(n);
            }
            PrintHeaderFooterLine(n);
        }
        static void PrintBodyLine(int n)
        {
            Console.Write('-');
            for (int i = 0; i < n - 2 / 2; i++)
            {
                Console.Write("\\/");
            }
            Console.Write('-');
            Console.WriteLine();
        }
        static void PrintHeaderFooterLine(int n)
        {
            Console.WriteLine(new String('-', n * 2));
        }
    }
}
