using System;

namespace _07.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine($"Before:\na = {a}\nb = {b}");

            int temp = Math.Max(a, b);
            b = Math.Min(a, b);
            a = temp;

            Console.WriteLine($"After:\na = {a}\nb = {b}");
        }
    }
}
