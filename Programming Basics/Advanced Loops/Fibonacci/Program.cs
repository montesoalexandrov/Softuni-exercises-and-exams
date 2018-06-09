using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());

                var f1 = 1;
                var f2 = 1;

                for (int i = 0; i < n - 1; i++)
                {
                    var nextF = f1 + f2;
                    f1 = f2;
                    f2 = nextF;
                }
                Console.WriteLine(f2);
            }
        }
    }
