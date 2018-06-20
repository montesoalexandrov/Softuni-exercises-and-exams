using System;

namespace _08.Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            NearestToCenter(x1, y1, x2, y2);
        }
        static void NearestToCenter(double x1, double y1, double x2, double y2)
        {
            Console.WriteLine(Math.Abs(x1) + Math.Abs(y1) <= Math.Abs(x2) + Math.Abs(y2) ? $"({x1}, {y1})" : $"({x2}, {y2})");
        }
    }
}
