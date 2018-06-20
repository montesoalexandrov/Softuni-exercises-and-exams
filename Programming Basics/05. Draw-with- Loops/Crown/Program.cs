using System;

namespace Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int widht = (2 * n) - 1;
            int height = (n / 2) + 4;

            Console.WriteLine("@{0}@{0}@", new string(' ', n - 2));
            Console.WriteLine("**{0}*{0}**", new string(' ', n - 3));

            for (int i = 0; i < n / 2 - 2; i++)
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', i + 1), new string(' ', Math.Abs(n - 5 - (2 * i))), new string('.', (i + 1) + i));                                                                                   
            }

            Console.WriteLine("*{0}*{1}*{0}*", new string('.', n / 2 - 1), new string('.', n - 3));
            Console.WriteLine("*{0}{1}.{1}{0}*", new string('.', n / 2), new string('*', n / 2 - 2));
            Console.WriteLine("{0}", new string('*', widht));
            Console.WriteLine("{0}", new string('*', widht));
        }
    }
}