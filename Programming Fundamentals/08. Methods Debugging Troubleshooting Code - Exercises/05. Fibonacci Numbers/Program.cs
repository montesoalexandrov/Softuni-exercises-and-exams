using System;
namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Fib(n);
        }
        private static void Fib(int n)
        {
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