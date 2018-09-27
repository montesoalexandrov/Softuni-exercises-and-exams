using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int numberOfLines = int.Parse(Console.ReadLine());
        var list = new List<Person>();

        for (int counter = 0; counter < numberOfLines; counter++)
        {
            var inputData = Console.ReadLine().Split(' ');
            var name = inputData[0];
            var age = int.Parse(inputData[1]);
            var person = new Person();
            person.Name = name;
            person.Age = age;

            if (person.Age > 30)
            {
                IsMoreThanThirty(person, list);
            }
        }

        PrintMoreThanThirtyList(list);
    }

    static void IsMoreThanThirty(Person person, List<Person> list)
    {
        list.Add(person);
    }

    static void PrintMoreThanThirtyList(List<Person> list)
    {
        foreach (var member in list.OrderBy(x => x.Name))
        {
            Console.WriteLine($"{member.Name} - {member.Age}");
        }
    }
}