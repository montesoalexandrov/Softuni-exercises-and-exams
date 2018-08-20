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
            var stack = new Stack<int>();
            foreach (var num in numbers)
            {
                stack.Push(num);
            }

            if (stack.Count == elementsToPush)
            {
                if (stack.Count >= numberOfElementsToPop)
                {
                    for (int i = 0; i < numberOfElementsToPop; i++)
                    {
                        stack.Pop();
                    }

                    if (stack.Contains(searchedElement))
                    {
                        Console.WriteLine("true");
                        return;
                    }
                }
            }
            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }

            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}