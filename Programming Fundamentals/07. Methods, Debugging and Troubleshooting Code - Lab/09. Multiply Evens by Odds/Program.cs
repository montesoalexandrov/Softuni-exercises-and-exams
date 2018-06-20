using System;

namespace _09.Multiply_Evens_by_Odds
{
    class Program
    {
        static int PrintMultipleOfEvensAndOdds(int n)
        {
            int sumEvens = GetSumOfEvenDigits(n);
            int sumOdd = GetSumOfOddDigits(n);
            return sumEvens * sumOdd;
        }
        static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }
        private static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(PrintMultipleOfEvensAndOdds(n));
        }
    }
}