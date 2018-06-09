using System;

namespace _07.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPower(num, power));
        }
        static double RaiseToPower(double num, int power)
        {
            double result = 1;
            result = Math.Pow(num, power);
            return result;
        }
    }
}
