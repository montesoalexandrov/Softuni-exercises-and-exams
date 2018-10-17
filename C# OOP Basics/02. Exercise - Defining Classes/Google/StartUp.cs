using System;
using System.Collections.Generic;
using System.Linq;

namespace Google
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();

            var input = String.Empty;

            while ((input = Console.ReadLine().Trim()) != "End")
            {
                var tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                var person = new Person(name);

                switch (tokens[1])
                {
                    case "company":
                        var company = new Company(tokens[2], tokens[3], double.Parse(tokens[4]));

                        if (persons.Any(p => p.Name == name))
                        {
                            persons.Where(p => p.Name == name).ToList().ForEach(p => p.Company = company);
                        }
                        else
                        {
                            person.Company = company;
                        }
                        break;
                    case "pokemon":
                        var pokemon = new Pokemon(tokens[2], tokens[3]);

                        if (persons.Any(p => p.Name == name))
                        {
                            persons.SingleOrDefault(p => p.Name == name).Pokemons.Add(pokemon);
                        }
                        else
                        {
                            person.Pokemons.Add(pokemon);
                        }
                        break;
                    case "parents":
                        var parent = new Parent(tokens[2], tokens[3]);

                        if (persons.Any(p => p.Name == name))
                        {
                            persons.SingleOrDefault(p => p.Name == name).Parents.Add(parent);
                        }
                        else
                        {
                            person.Parents.Add(parent);
                        }
                        break;
                    case "children":
                        var children = new Children(tokens[2], tokens[3]);
                        if (persons.Any(p => p.Name == name))
                        {
                            persons.SingleOrDefault(p => p.Name == name).Childrens.Add(children);
                        }
                        else
                        {
                            person.Childrens.Add(children);
                        }
                        break;
                    case "car":
                        var car = new Car(tokens[2], int.Parse(tokens[3]));
                        if (persons.Any(p => p.Name == name))
                        {
                            if (persons.SingleOrDefault(p => p.Name == name).Car == null)
                            {
                                persons.SingleOrDefault(p => p.Name == name).Car = car;
                            }
                        }
                        else
                        {
                            person.Car = car;
                        }
                        break;
                }

                if (!persons.Any(p => p.Name == name))
                {
                    persons.Add(person);
                }
            }

            var outputName = Console.ReadLine();
            Console.WriteLine(persons.First(p => p.Name == outputName).ToString());
        }
    }
}