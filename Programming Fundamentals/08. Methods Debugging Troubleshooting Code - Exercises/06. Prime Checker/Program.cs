using System;
namespace _06.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            IsPrime(n);
        }
        static void IsPrime(long n)
        {
            var prime = true;

            if (n <= 1)
            {
                Console.WriteLine("False");
            }
            else
            {
                for (var i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }
    }
}