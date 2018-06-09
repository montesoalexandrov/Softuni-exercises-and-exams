using System;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredients = int.Parse(Console.ReadLine());
            double calories = 0;
            string products = "";

            for (int i = 0; i < ingredients; i++)
            {
                products = Console.ReadLine().ToLower();

                if (products == "cheese")
                {
                    calories += 500;
                }
                else if (products == "tomato sauce")
                {
                    calories += 150;
                }
                else if (products == "salami")
                {
                    calories += 600;
                }
                else if (products == "pepper")
                {
                    calories += 50;
                }
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
