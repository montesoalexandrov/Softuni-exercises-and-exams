using System;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredient = Console.ReadLine();
            int counter = 0;

            while (ingredient != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");
                counter++;
                ingredient = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
