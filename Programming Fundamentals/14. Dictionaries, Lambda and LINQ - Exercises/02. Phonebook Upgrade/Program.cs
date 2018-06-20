using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();
            var phonebook = new SortedDictionary<string, string>();
            while (input[0] != "END")
            {
                switch (input[0])
                {
                    case "A":
                        if (phonebook.Keys.Contains(input[1]))
                        {
                            phonebook.Remove(input[1]);
                        }
                        phonebook.Add(input[1], input[2]);
                        break;
                    case "S":
                        if (phonebook.Keys.Contains(input[1]))
                        {
                            Console.WriteLine($"{input[1]} -> {phonebook[input[1]]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {input[1]} does not exist.");
                        }
                        break;
                    case "ListAll":
                        foreach (var p in phonebook)
                        {
                            Console.WriteLine($"{p.Key} -> {p.Value}");
                        }
                        break;
                }
                input = Console.ReadLine().Split().ToList();
            }
        }
    }
}