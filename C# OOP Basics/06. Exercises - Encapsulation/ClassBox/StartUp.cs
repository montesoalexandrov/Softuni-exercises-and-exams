using System;

namespace ClassBox
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            var Box = new Box(length, width, height);

            Console.WriteLine(Box.GetSurfaceArea());
            Console.WriteLine(Box.GetLateralSurfaceArea());
            Console.WriteLine(Box.GetVolume());
        }
    }
}