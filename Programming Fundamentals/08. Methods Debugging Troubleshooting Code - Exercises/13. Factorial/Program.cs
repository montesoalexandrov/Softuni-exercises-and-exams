using System;
using System.Numerics;
namespace _13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(SumFactorial(n));
        }
        static BigInteger SumFactorial(int n)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}