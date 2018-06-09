using System;

namespace _02.Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var heigth = double.Parse(Console.ReadLine());

            Console.WriteLine($"{width * heigth:f2}");
        }
    }
}
