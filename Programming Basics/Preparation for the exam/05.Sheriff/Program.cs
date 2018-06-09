using System;

namespace _05.Sheriff
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int widht = 3 * n;
            int height = 2 * n + 8; 

            Console.WriteLine("{0}x{0}", new string('.', (widht - 1) / 2));
            Console.WriteLine("{0}/x\\{0}", new string('.', (widht - 3) / 2));
            Console.WriteLine("{0}x|x{0}", new string('.', (widht - 3) / 2));

            for (int i = 0; i <= n / 2; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string ('.', n / 2 - i), new string ('x', n + i));
            }

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', n / 2 - i), new string('x', n + i));
            }

            Console.WriteLine("{0}/x\\{0}", new string('.', (widht - 3) / 2));
            Console.WriteLine("{0}\\x/{0}", new string('.', (widht - 3) / 2));

            for (int i = 0; i <= n / 2; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', n / 2 - i), new string('x', n + i));
            }

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', n / 2 - i), new string('x', n + i));
            }

            Console.WriteLine("{0}x|x{0}", new string('.', (widht - 3) / 2));
            Console.WriteLine("{0}\\x/{0}", new string('.', (widht - 3) / 2));
            Console.WriteLine("{0}x{0}", new string('.', (widht - 1) / 2));
        }
    }
}
