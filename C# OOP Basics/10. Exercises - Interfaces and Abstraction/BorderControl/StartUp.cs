namespace BorderControl
{
    using System;
    using BorderControl.Models;
    using BorderControl.Contracts;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main(string[] args)
        {
            var humansAndRobots = new Queue<IIdentifiable>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")   
            {
                string[] tokens = input.Split();
                if (tokens.Length == 3)
                {
                    humansAndRobots.Enqueue(new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]));
                }
                else
                {
                    humansAndRobots.Enqueue(new Robot(tokens[0], tokens[1]));
                }
            }

            string fakeId = Console.ReadLine();

            foreach (var person in humansAndRobots)
            {
                string lastDigits = person.Id.Substring(person.Id.Length - fakeId.Length);

                if (lastDigits == fakeId)
                {
                    Console.WriteLine(person.Id);
                }
            }
        }
    }
}