using System;
using System.Collections.Generic;

namespace _05._Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new HashSet<string>();
            int numberOfNames = int.Parse(Console.ReadLine());

            for (int counter = 0; counter < numberOfNames; counter++)
            {
                var input = Console.ReadLine();
                names.Add(input);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}