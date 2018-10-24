using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int counter = 0; counter < numberOfCars; counter++)
            {
                Car car = ReadData();
                cars.Add(car);
            }

            var command = Console.ReadLine();
            PrintResult(cars, command);
        }

        private static void PrintResult(List<Car> cars, string command)
        {
            if (command == "fragile")
            {
                cars.Where(x => x.Cargo.Type == "fragile" && x.Tyres.Any(c => c.Pressure < 1)).Select(m => m.Model).ToList().ForEach(x => Console.WriteLine(x));
            }
            else if (command == "flamable")
            {
                cars.Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250).Select(m => m.Model).ToList().ForEach(x => Console.WriteLine(x));
            }
        }

        private static Car ReadData()
        {
            string[] inputData = Console.ReadLine().Split();

            var currentModel = inputData[0];
            var currentEngine = new Engine(int.Parse(inputData[1]), int.Parse(inputData[2]));
            var currentCargoType = new Cargo(int.Parse(inputData[3]), inputData[4]);
            var currentTires = new List<Tyre>()
                {
                    new Tyre(double.Parse(inputData[5]), int.Parse(inputData[6]))
                    , new Tyre(double.Parse(inputData[7]), int.Parse(inputData[8]))
                    , new Tyre(double.Parse(inputData[9]), int.Parse(inputData[10]))
                    , new Tyre(double.Parse(inputData[11]), int.Parse(inputData[12]))
                };
            var car = new Car(currentModel, currentEngine, currentCargoType, currentTires);
            return car;
        }
    }
}