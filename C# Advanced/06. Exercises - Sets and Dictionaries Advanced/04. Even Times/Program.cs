using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new Dictionary<int, int>();

            int numberOfIntegers = int.Parse(Console.ReadLine());

            for (int count = 0; count < numberOfIntegers; count++)
            {
                int num = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(num))
                {
                    numbers.Add(num, 1);
                }
                else
                {
                    numbers[num]++;
                }
            }

            foreach (var n in numbers.Where(n => n.Value % 2 == 0))
            {
                Console.WriteLine(n.Key);
            }
        }
    }
}