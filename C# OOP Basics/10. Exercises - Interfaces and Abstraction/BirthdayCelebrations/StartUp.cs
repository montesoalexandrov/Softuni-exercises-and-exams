namespace BirthdayCelebrations
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using BirthdayCelebrations.Models;
    using BirthdayCelebrations.Contracts;

    public class StartUp
    {
        static void Main(string[] args)
        {
            var creatures = new Queue<IBirthable>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();

                if (tokens[0] == "Citizen")
                {
                    creatures.Enqueue(new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]));
                }
                else if (tokens[0] == "Pet")
                {
                    creatures.Enqueue(new Pet(tokens[1], tokens[2]));
                }
            }

            var birthYear = int.Parse(Console.ReadLine());

            creatures.Where(c => c.Birthdate.Year == birthYear).ToList().ForEach(c => Console.WriteLine($"{c.Birthdate:dd/mm/yyyy}"));
        }
    }
}