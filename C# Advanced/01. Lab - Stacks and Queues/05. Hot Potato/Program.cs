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
            var children = Console.ReadLine().Split(' ');
            var tossLimit = int.Parse(Console.ReadLine());
            var queqe = new Queue<string>(children);

            while (queqe.Count != 1)
            {
                for (int tossCounter = 1; tossCounter < tossLimit; tossCounter++)
                {
                    queqe.Enqueue(queqe.Dequeue());
                }

                Console.WriteLine($"Removed {queqe.Dequeue()}");
            }
            Console.WriteLine($"Last is {queqe.Dequeue()}");
        }
    }
}