using System;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine().ToLower();
            double price = 0;

            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }

            else if (groupSize <= 50)
            {
                price += 2500.00;
                if (package == "normal")
                {
                    price += 500.00;
                    price = (price - (price * 0.05)) / groupSize;
                    Console.WriteLine($"We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {price:f2}$");
                }

                else if (package == "gold")
                {
                    price += 750.00;
                    price = (price - (price * 0.10)) / groupSize;
                    Console.WriteLine($"We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {price:f2}$");
                }

                else if (package == "platinum")
                {
                    price += 1000.00;
                    price = (price - (price * 0.15)) / groupSize;
                    Console.WriteLine($"We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {price:f2}$");
                }
            }

            else if (groupSize > 50 && groupSize <= 100)
            {
                price += 5000.00;
                if (package == "normal")
                {
                    price += 500.00;
                    price = (price - (price * 0.05)) / groupSize;
                    Console.WriteLine($"We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {price:f2}$");
                }

                else if (package == "gold")
                {
                    price += 750.00;
                    price = (price - (price * 0.10)) / groupSize;
                    Console.WriteLine($"We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {price:f2}$");
                }

                else if (package == "platinum")
                {
                    price += 1000.00;
                    price = (price - (price * 0.15)) / groupSize;
                    Console.WriteLine($"We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {price:f2}$");
                }
            }

            else if (groupSize > 100 && groupSize <= 120)
            {
                price += 7500.00;
                if (package == "normal")
                {
                    price += 500;
                    price = (price - (price * 0.05)) / groupSize;
                    Console.WriteLine($"We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {price:f2}$");
                }

                else if (package == "gold")
                {
                    price += 750.00;
                    price = (price - (price * 0.10)) / groupSize;
                    Console.WriteLine($"We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {price:f2}$");
                }

                else if (package == "platinum")
                {
                    price += 1000.00;
                    price = (price - (price * 0.15)) / groupSize;
                    Console.WriteLine($"We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {price:f2}$");
                }
            }
        }
    }
}
