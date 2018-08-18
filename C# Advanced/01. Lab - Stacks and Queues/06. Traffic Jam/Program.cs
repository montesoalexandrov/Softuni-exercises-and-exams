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
            var carsPerGreenLight = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var carsQueqe = new Queue<string>();
            int carsThatPassedTotal = 0;

            while (input != "end")
            {
                if (input == "green")
                {
                    var carThanCanPass = Math.Min(carsQueqe.Count, carsPerGreenLight);
                    for (int counter = 0; counter < carThanCanPass; counter++)
                    {
                        Console.WriteLine($"{carsQueqe.Dequeue()} passed!");
                        carsThatPassedTotal++;
                    }
                }
                else
                {
                    carsQueqe.Enqueue(input);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"{carsThatPassedTotal} cars passed the crossroads.");
        }
    }
}