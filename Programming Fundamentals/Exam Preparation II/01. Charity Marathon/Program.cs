using System;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfMarathon = int.Parse(Console.ReadLine());
            int numberOfRunners = int.Parse(Console.ReadLine());
            int averageLaps = int.Parse(Console.ReadLine());
            double trackLength = double.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            double moneyPerKilometer = double.Parse(Console.ReadLine());

            int maxRunners = daysOfMarathon * trackCapacity;
            double totalMeters = 0;

            if (numberOfRunners > maxRunners)
            {
                totalMeters = maxRunners * averageLaps * trackLength;
            }
            else
            {
                totalMeters = numberOfRunners * averageLaps * trackLength;
            }

            double totalKilometers = totalMeters / 1000.00;
            double money = moneyPerKilometer * totalKilometers;

            Console.WriteLine($"Money raised: {money:f2}");
        }
    }
}