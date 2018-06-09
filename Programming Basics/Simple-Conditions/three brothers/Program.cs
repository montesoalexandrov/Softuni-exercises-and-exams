using System;

namespace three_brothers
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = double.Parse(Console.ReadLine());
            var B = double.Parse(Console.ReadLine());
            var C = double.Parse(Console.ReadLine());
            var D = double.Parse(Console.ReadLine());

            var totalTime = 1 / (1/A + 1/B + 1/C);
            var timeWithRest = totalTime + (totalTime * 0.15);
            var surprise = Math.Abs(D - timeWithRest);

            Console.WriteLine($"Cleaning time: {timeWithRest:f2}");

            if (timeWithRest < D) Console.WriteLine("Yes, there is a surprise - time left -> " + Math.Floor(surprise) + " hours.");
            else if (timeWithRest > D) Console.WriteLine("No, there isn't a surprise - shortage of time -> " + Math.Ceiling(surprise) + " hours.");
        }
    }
}
