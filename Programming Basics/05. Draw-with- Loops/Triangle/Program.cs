using System;

namespace Триъгълник
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int widht = (4 * n) + 1;
            int height = (2 * n) + 1;

            Console.WriteLine("{0}", new string('#', widht));

            for (int i = 0; i < n; i++)
            {
                if (i < n / 2)
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', i + 1), new string('#', ((2 * n) - 1) - 2 * i), new string(' ', 2 * i + 1));
                }
                if (i == n / 2 - 1)
                {
                    Console.WriteLine("{0}{1}{2}(@){2}{1}{0}", new string('.', i + 2), new string('#', ((2 * n) - 3) - 2 * i), new string(' ', i));
                }
                else if (i > n / 2)
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', 1 + i), new string('#', (4 * n - 2) / 2 - (2 * i)), new string(' ', 1 + 2 * i));
        }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', (n + 1) + i ), new string('#', (2 * n - 1) - 2 * i));
            }
        }
    }
}