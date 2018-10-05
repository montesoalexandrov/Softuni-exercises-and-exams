using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new HashSet<string>();

            var input = String.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                var tokens = input.Split(", ");
                switch (tokens[0])
                {
                    case "IN":
                        cars.Add(tokens[1]);
                        break;
                    case "OUT":
                        cars.Remove(tokens[1]);
                        break;
                }
            }

            if (cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}