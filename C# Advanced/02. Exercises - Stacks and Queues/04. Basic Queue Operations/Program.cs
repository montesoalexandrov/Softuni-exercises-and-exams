using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var elementsToPush = int.Parse(input[0]);
            var numberOfElementsToPop = int.Parse(input[1]);
            var searchedElement = int.Parse(input[2]);
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse);
            var queqe = new Queue<int>();
            foreach (var num in numbers)
            {
                queqe.Enqueue(num);
            }

            if (queqe.Count == elementsToPush)
            {
                if (queqe.Count >= numberOfElementsToPop)
                {
                    for (int i = 0; i < numberOfElementsToPop; i++)
                    {
                        queqe.Dequeue();
                    }

                    if (queqe.Contains(searchedElement))
                    {
                        Console.WriteLine("true");
                        return;
                    }
                }
            }
            if (queqe.Count == 0)
            {
                Console.WriteLine(0);
            }

            else
            {
                Console.WriteLine(queqe.Min());
            }
        }
    }
}