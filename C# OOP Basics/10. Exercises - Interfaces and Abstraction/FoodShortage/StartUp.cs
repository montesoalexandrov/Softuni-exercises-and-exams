namespace FoodShortage
{
    using System;
    using System.Linq;
    using FoodShortage.Models;
    using FoodShortage.Contracts;
    using System.Collections.Generic;
    using BirthdayCelebrations.Models;

    class StartUp
    {
        static void Main(string[] args)
        {
            var persons = new Queue<IBuyer>();

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();

                if (tokens.Length == 4)
                {
                    persons.Enqueue(new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]));
                }
                else if (tokens.Length == 3)
                {
                    persons.Enqueue(new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]));
                }
                else
                {
                    var person = persons.FirstOrDefault(x => x.Name == tokens[0]);
                    person?.BuyFood();
                }
            }

            Console.WriteLine(persons.Sum(p => p.Food));
        }
    }
}