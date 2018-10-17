using System;
using System.Linq;
using System.Collections.Generic;

namespace OpinionPoll
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int counter = 0; counter < numberOfLines; counter++)
            {
                string[] inputData = Console.ReadLine().Split();

                string name = inputData[0];
                int age = int.Parse(inputData[1]);

                if (age > 30)
                {
                    var person = new Person(name, age);
                    persons.Add(person);
                }
            }

            foreach (var person in persons.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}