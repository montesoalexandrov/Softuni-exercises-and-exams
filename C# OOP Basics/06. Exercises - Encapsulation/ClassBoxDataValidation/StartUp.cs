using System;

namespace ClassBoxDataValidation
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                var Box = new Box(length, width, height);

                Console.WriteLine(Box.GetSurfaceArea());
                Console.WriteLine(Box.GetLateralSurfaceArea());
                Console.WriteLine(Box.GetVolume());
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
        }
    }
}