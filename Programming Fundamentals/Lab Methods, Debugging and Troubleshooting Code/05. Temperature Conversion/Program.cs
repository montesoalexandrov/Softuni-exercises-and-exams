using System;

namespace _05.Temperature_Conversion
{
    class Program
    {
        static double ConvFarenToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
        static void Main(string[] args)
        {
            var fahrenheit = double.Parse(Console.ReadLine());
            var celsius = ConvFarenToCelsius(fahrenheit);
            Console.WriteLine($"{celsius:f2}");
        }
    }
}
