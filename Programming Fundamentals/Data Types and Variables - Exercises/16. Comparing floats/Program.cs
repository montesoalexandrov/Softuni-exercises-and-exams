using System;

namespace _16.Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            bool isTrue = true;
            if (Math.Abs(num1 - num2) <= 0.000001) { Console.WriteLine(isTrue); }
            else { isTrue = false; Console.WriteLine(isTrue); }
        }
    }
}
