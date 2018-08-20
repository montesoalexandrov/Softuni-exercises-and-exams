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
            long num = long.Parse(Console.ReadLine());

            var queue = new Queue<long>();
            Console.Write(num + " ");

            for (int i = 0; i < 17; i++)
            {
                queue.Enqueue(num + 1);
                queue.Enqueue(2 * num + 1);
                queue.Enqueue(num + 2);

                num = queue.Dequeue();

                Console.Write(num + " ");
            }
            for (int i = 0; i < 32; i++)
            {
                Console.Write(queue.Dequeue() + " ");
            }
        }
    }
}