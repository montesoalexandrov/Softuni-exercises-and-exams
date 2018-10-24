namespace PizzaCalories
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] pizzaName = Console.ReadLine().Split();
            string[] pizzaDough = Console.ReadLine().Split();

            Pizza pizza = null;

            try
            {
                pizza = new Pizza(pizzaName[1], new Dough(pizzaDough[1], pizzaDough[2], double.Parse(pizzaDough[3])));
            }
            catch (ArgumentException ArgEx)
            {
                Console.WriteLine(ArgEx.Message);
                Environment.Exit(0);
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] toppingData = input.Split();

                try
                {
                    pizza.Toppings.Enqueue(new Topping(toppingData[1], double.Parse(toppingData[2])));
                }
                catch (ArgumentException ArgEx)
                {
                    Console.WriteLine(ArgEx.Message);
                    Environment.Exit(0);
                }
            }

            double calories = pizza.CalculateCalories();

            Console.WriteLine($"{pizza.Name} - {calories:f2} Calories.");
        }
    }
}