using System;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyContent = int.Parse(Console.ReadLine());
            var sugarContent = int.Parse(Console.ReadLine());

            var energy = energyContent * volume / 100.0;
            var sugar = sugarContent * volume / 100.0;

            Console.WriteLine($"{volume}ml {name}:\n{energy}kcal, {sugar}g sugars");
        }
    }
}
