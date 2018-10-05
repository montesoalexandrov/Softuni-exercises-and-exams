using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();

            var setLength = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int counter = 0; counter < setLength[0]; counter++)
            {
                var num = int.Parse(Console.ReadLine());
                firstSet.Add(num);
            }

            for (int counter = 0; counter < setLength[1]; counter++)
            {
                var num = int.Parse(Console.ReadLine());
                secondSet.Add(num);
            }

            foreach (var num in firstSet)
            {
                if (secondSet.Contains(num))
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}