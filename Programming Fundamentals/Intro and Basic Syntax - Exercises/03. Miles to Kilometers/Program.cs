using System;

namespace _03.Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var distance = double.Parse(Console.ReadLine());
            var distanceInMiles = distance * 1.60934;

            Console.WriteLine($"{distanceInMiles:f2}");
        }
    }
}
