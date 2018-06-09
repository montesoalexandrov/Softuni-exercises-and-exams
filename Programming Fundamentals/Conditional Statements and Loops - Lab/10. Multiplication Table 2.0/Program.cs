using System;

namespace _10.Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());

            if (n > 10)
            {
                Console.WriteLine($"{num} X {n} = {num * n}");
            }

            for (int i = n; i <= 10; i++)
            {
                Console.WriteLine($"{num} X {i} = {num * i}");
            }
        }
    }
}
