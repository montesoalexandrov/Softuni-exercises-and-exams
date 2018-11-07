using System;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            var car = new Car(double.Parse(input[1]), double.Parse(input[2]));
            input = Console.ReadLine().Split();
            var truck = new Truck(double.Parse(input[1]), double.Parse(input[2]));

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
                    } else
                    {
                        truck.Drive(distancesOrQuantity);
                    }
                }
                else
                {
                    if (input[1] == "Car")
                    {
                        car.Refuel(distancesOrQuantity);
                    }
                    else
                    {
                        truck.Refuel(distancesOrQuantity);
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }
    }
}