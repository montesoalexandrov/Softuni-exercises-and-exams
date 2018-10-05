using System;
using System.Collections.Generic;

namespace _05._Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            var people = new Dictionary<string, int>();

            for (int counter = 0; counter < peopleCount; counter++)
            {
                var nameAndAge = Console.ReadLine()
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                people.Add(nameAndAge[0], int.Parse(nameAndAge[1]));
            }

            var condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();
            var filter = CreateFilter(condition, age);
            var printer = CreatePrinter(format);

            printPeople(people, filter, printer);
        }

        private static void printPeople(Dictionary<string, int> people, Func<int, bool> filter, Action<KeyValuePair<string, int>> printer)
        {
            foreach (var person in people)
            {
                if (filter(person.Value))
                {
                    printer(person);
                }
            }
        }

        static Func<int, bool> CreateFilter(string condition, int age)
        {
            if (condition == "younger")
            {
                return x => x < age;
            }

            else
            {
                return x => x >= age;
            }
        }

        static Action<KeyValuePair<string, int>> CreatePrinter(string format)
        {
            switch (format)
            {
                case "name":
                    return x => Console.WriteLine(x.Key); 
                case "name age":
                    return x => Console.WriteLine($"{x.Key} - {x.Value}");
                case "age":
                    return x => Console.WriteLine(x.Value);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}