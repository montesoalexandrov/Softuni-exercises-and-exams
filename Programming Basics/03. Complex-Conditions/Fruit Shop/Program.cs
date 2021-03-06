﻿using System;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine();
            var day = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());
            var price = -1.0;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    price = 2.50 * quantity;
                }
                else if (fruit == "apple")
                {
                    price = 1.20 * quantity;
                }
                else if (fruit == "orange")
                {
                    price = 0.85 * quantity;
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.45 * quantity;
                }
                else if (fruit == "kiwi")
                {
                    price = 2.70 * quantity;
                }
                else if (fruit == "pineapple")
                {
                    price = 5.50 * quantity;
                }
                else if (fruit == "grapes")
                {
                    price = 3.85 * quantity;
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    price = 2.70 * quantity;
                }
                else if (fruit == "apple")
                {
                    price = 1.25 * quantity;
                }
                else if (fruit == "orange")
                {
                    price = 0.90 * quantity;
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.60 * quantity;
                }
                else if (fruit == "kiwi")
                {
                    price = 3.00 * quantity;
                }
                else if (fruit == "pineapple")
                {
                    price = 5.60 * quantity;
                }
                else if (fruit == "grapes")
                {
                    price = 4.20 * quantity;
                }
            }
            if (price >= 0)
            {
                Console.WriteLine("{0:f2}", price);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
