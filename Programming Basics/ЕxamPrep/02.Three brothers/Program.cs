using System;

namespace _02.Three_brothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());
            double fatherTime = double.Parse(Console.ReadLine());

            double totalTime = 1 / (1 / first + 1 / second + 1 / third);
            double timeWithRest = totalTime + (totalTime * 0.15);
            double sum = Math.Abs(fatherTime - timeWithRest);

            Console.WriteLine($"Cleaning time: {timeWithRest:f2}");

            if (fatherTime > timeWithRest)
            {
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(sum)} hours.");
            }

            else
            {
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(sum)} hours. ");
            }
        }
    }
}
