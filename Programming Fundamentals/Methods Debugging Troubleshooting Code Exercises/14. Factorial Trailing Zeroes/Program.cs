using System;
using System.Numerics;
namespace _14.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(CountTrailingZeroes(n));
        }
        static BigInteger CountTrailingZeroes(int n)
        {
            BigInteger factorial = 1;
            int counter = 0;
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }
            var factorialToString = factorial.ToString();
            for (var j = factorialToString.Length - 1; j > 0; j--)
            {
                var lastDigit = factorialToString[j];

                if (lastDigit == '0')
                {
                    counter += 1;
                }
                else
                {
                    break;
                }
            }
            return counter;
        }
    }
}