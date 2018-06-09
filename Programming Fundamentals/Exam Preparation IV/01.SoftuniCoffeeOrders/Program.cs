using System;
using System.Globalization;

namespace _01.SoftuniCoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOrders = int.Parse(Console.ReadLine());

            decimal totalPrice = 0;

            for (int i = 0; i < countOrders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);

                long countCapsule = long.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
                decimal price = (daysInMonth * countCapsule) * pricePerCapsule;

                Console.WriteLine($"The price for the coffee is: ${price:F2}");

                totalPrice += price;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}