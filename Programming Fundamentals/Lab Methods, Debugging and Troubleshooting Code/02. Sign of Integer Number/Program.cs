using System;

namespace _02.Sign_of_Integer_Number
{
    class Program
    {
        static void Number()
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 0) { Console.WriteLine($"The number {n} is zero."); }
            else if (n > 0) { Console.WriteLine($"The number {n} is positive."); }
            else { Console.WriteLine($"The number {n} is negative."); }
        }
        static void Main(string[] args)
        {
            Number();
        }
    }
}   