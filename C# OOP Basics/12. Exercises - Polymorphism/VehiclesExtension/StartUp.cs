using System;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            var car = new Car(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
            input = Console.ReadLine().Split();
            var truck = new Truck(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
            input = Console.ReadLine().Split();
            var bus = new Bus(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));

            int numberOfLines = int.Parse(Console.ReadLine());

            for (int counter = 0; counter < numberOfLines; counter++)
            {
                input = Console.ReadLine().Split();
                double distancesOrQuantity = double.Parse(input[2]);

                if (input[0] == "Drive")
                {
                    if (input[1] == "Car")
                    {
                        car.Drive(distancesOrQuantity);
                    }
                    else if (input[1] == "Truck")
                    {
                        truck.Drive(distancesOrQuantity);
                    }
                    else
                    {
                        bus.Drive(distancesOrQuantity);
                    }
                }
                else if (input[0] == "Refuel")
                {
                    if (input[1] == "Car")
                    {
                        car.Refuel(distancesOrQuantity);
                    }
                    else if (input[1] == "Truck")
                    {
                        truck.Refuel(distancesOrQuantity);
                    }
                    else
                    {
                        truck.Refuel(distancesOrQuantity);
                    }
                }
                else
                {
                    bus.DriveEmptyBus(distancesOrQuantity);
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
    }
}