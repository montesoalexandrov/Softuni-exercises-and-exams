using System;

namespace Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int height = 2 * n + 4;
            int widht = 5 * n;
            string dance = "D^A^N^C^E^";

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', n + i), new string('#', (widht - n * 2) - (i * 2)));
            }

            for (int i = 0; i < n / 2 + 1; i++)
            {
                   Console.WriteLine("{0}#{1}#{0}", new string('.', (n * 3) / 2 + i), new string('.', (n * 2 - 2 - (i * 2))));
            }

            Console.WriteLine("{0}{1}{0}", new string('.', 2 * n), new string('#', n));

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', 2 * n - 2), new string('#', n + 4));
            }

            Console.WriteLine("{0}{1}{0}", new string('.', (widht - 10) / 2), dance);

            for (int i = 0; i < (n / 2) + 1; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', 2 * n - 2), new string('#', n + 4));
            }
        }
    }
}