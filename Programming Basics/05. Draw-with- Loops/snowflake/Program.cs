using System;

namespace snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int height = 2 * n + 1;
            int widht = 2 * n + 3;

            Console.WriteLine("*{0}*{0}*", new string('.', n));

            for (int i = 1; i <= n - 2; i++)
            {
                Console.WriteLine("{1}*{0}*{0}*{1}", new string('.', n - i), new string ('.',i));
            }

            Console.WriteLine("{0}{1}{0}", new string('.', n - 1), new string('*', 5));
            Console.WriteLine("{0}", new string('*', widht));
            Console.WriteLine("{0}{1}{0}", new string('.', n - 1), new string('*', 5));

            for (int i = n - 2;  i >= 0; i--)
            {
                Console.WriteLine("{1}*{0}*{0}*{1}", new string('.', n - i), new string('.', i));
            }
        }
    }
}
