using System;
namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var figureType = Console.ReadLine();
            var side = 0;
            var height = 0;
            var width = 0;
            var radius = 0;
            if (figureType == "triangle")
            {
                SumTriangleArea(side, height);
            }
            else if (figureType == "square")
            {
                SumSquareArea(side);
            }
            else if (figureType == "rectangle")
            {
                SumRectangleArea(width, height);
            }
            else if (figureType == "circle")
            {
                SumCircleArea(radius);
            }
        }
        static void SumTriangleArea(double side, double height)
        {
            side = double.Parse(Console.ReadLine());
            height = double.Parse(Console.ReadLine());
            Console.WriteLine($"{(side * height) / 2:f2}");
        }
        static void SumSquareArea(double side)
        {
            side = double.Parse(Console.ReadLine());
            Console.WriteLine($"{side * side:f2}");
        }
        static void SumRectangleArea(double width, double height)
        {
            width = double.Parse(Console.ReadLine());
            height = double.Parse(Console.ReadLine());
            Console.WriteLine($"{width * height:f2}");
        }
        static void SumCircleArea(double radius)
        {
            radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Math.PI * radius * radius:f2}");
        }
    }
}