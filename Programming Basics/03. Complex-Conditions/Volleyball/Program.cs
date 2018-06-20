using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var p = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var result = (48 - h) / 4 * 3 + h + p / 3 * 2;
            var games = 0.0;

            if (year == "leap") games = result * 1.15;
            else if (year == "normal") games = result;

            Console.WriteLine(Math.Truncate(games));
        }
    }
}
