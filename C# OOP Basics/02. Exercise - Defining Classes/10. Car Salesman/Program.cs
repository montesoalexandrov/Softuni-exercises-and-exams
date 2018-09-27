using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var engines = new List<Engine>();
        var cars = new Queue<Car>();

        int numberOfEngines = int.Parse(Console.ReadLine());

        for (int count = 0; count < numberOfEngines; count++)
        {
            var inputData = Console.ReadLine().Split( new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var engineModel = inputData[0];
            int enginePower = int.Parse(inputData[1]);
            var engineDisplacement = "n/a";
            var engineEfficiency = "n/a";

            if (inputData.Length == 3)
            {
                int tryParse = 0;

                bool isEngineDisplacement = int.TryParse(inputData[2], out tryParse);

                if (!isEngineDisplacement)
                {
                    engineEfficiency = inputData[2];
                    engineDisplacement = "n/a";
                }
                else
                {
                    engineDisplacement = tryParse.ToString();
                    engineEfficiency = "n/a";
                }
            }

            else if (inputData.Length == 4)
            {
                engineDisplacement = inputData[2];
                engineEfficiency = inputData[3];
            }

            var engine = new Engine(engineModel, enginePower, engineDisplacement, engineEfficiency);
            engines.Add(engine);
        }

        int numberOfCars = int.Parse(Console.ReadLine());

        for (int counter = 0; counter < numberOfCars; counter++)
        {
            var inputData = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var carName = inputData[0];
            var carEngine = engines.First(d => d.Model == inputData[1]);
            var carWeight = "n/a";
            var carColor = "n/a";

            if (inputData.Length == 3)
            {
                int tryParse = 0;

                bool isCarWeight = int.TryParse(inputData[2], out tryParse);

                if (!isCarWeight)
                {
                    carColor = inputData[2];
                    carWeight = "n/a";
                }
                else
                {
                    carWeight = tryParse.ToString();
                    carColor = "n/a";
                }

            }

            else if (inputData.Length == 4)
            {
                carWeight = inputData[2];
                carColor = inputData[3];
            }

            var car = new Car(carName, carEngine, carWeight, carColor);
            cars.Enqueue(car);
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car.ToString());
        }
    }
}