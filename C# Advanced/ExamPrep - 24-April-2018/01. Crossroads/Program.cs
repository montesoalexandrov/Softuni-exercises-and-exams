using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var carsQueue = new Queue<string>();

        int greenLightDuration = int.Parse(Console.ReadLine());
        int freeWindowDuration = int.Parse(Console.ReadLine());

        var input = String.Empty;
        int carInCrossroad = 0;
        var tempCar = string.Empty;
        var currentCar = string.Empty;
        int carsCounter = 0;
        int tempGreenLightDuration = greenLightDuration;

        while ((input = Console.ReadLine()) != "END")
        {
            if (input == "green")
            {
                tempGreenLightDuration = greenLightDuration;

                while (carsQueue.Count != 0)
                {
                    tempCar = carsQueue.Dequeue();

                    if (tempGreenLightDuration > 0)
                    {
                        if (tempCar.Length <= tempGreenLightDuration)
                        {
                            tempGreenLightDuration -= tempCar.Length;
                            carsCounter++;
                        }
                        else
                        {
                            currentCar = tempCar;
                            tempCar = tempCar.Substring(tempGreenLightDuration);
                            carInCrossroad = tempCar.Length;
                            tempGreenLightDuration = -1;
                        }
                    }

                    if (tempGreenLightDuration == 0)
                    {
                        break;
                    }

                    else if (tempGreenLightDuration == -1)
                    {
                        if (freeWindowDuration < carInCrossroad)
                        {
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{currentCar} was hit at {currentCar[freeWindowDuration + 1]}.");
                            Environment.Exit(0);
                        }
                        else
                        {
                            carsCounter++;
                            break;
                        }
                    }
                }
            }

            else
            {
                carsQueue.Enqueue(input);
            }
        }

        Console.WriteLine("Everyone is safe.");
        Console.WriteLine($"{carsCounter} total cars passed the crossroads.");
    }
}