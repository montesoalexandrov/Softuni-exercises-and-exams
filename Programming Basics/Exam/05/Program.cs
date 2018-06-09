using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int widht = 3 * n + 6;
            int height = 3 * n + 1;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}~ ~ ~{1}", new string(' ', n), new string(' ', n * 2));
            }

            Console.WriteLine("{0}", new string('=', widht - 1));

            if (n == 3)
            {
                Console.WriteLine("|{0}JAVA{0}|{1}|", new string('~', n), new string(' ', n - 1));
            }

            else
            {
                for (int i = 1; i < n - 2; i++)
                {
                    Console.WriteLine("|{0}|{1}|", new string('~', 2 * n + 4), new string(' ', n - 1));

                    if (i == n / 2 - 1)
                    {
                        Console.WriteLine("|{0}JAVA{0}|{1}|", new string('~', n), new string(' ', n - 1));
                    }
                }
            }

            Console.WriteLine("{0}", new string('=', widht - 1));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/", new string(' ', i), new string('@', Math.Abs(2 * n - 4 - (i * 2) + 8)));
            }

            Console.WriteLine("{0}", new string('=', widht - (n)));
        }
    }
}
