using System;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = new SortedSet<string>();

            var inputLines = int.Parse(Console.ReadLine());

            for (int counter = 0; counter < inputLines; counter++)
            {
                var inputElements = Console.ReadLine().Split();

                foreach (var element in inputElements)
                {
                    elements.Add(element);
                }
            }
            
            Console.WriteLine(String.Join(" ", elements));
        }
    }
}