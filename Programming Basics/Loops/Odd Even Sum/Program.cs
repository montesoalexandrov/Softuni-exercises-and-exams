using System;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int evenNum = 0;
            int oddNum = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenNum += currentNum;
                }

                else if (i % 2 != 0)
                {
                    oddNum += currentNum;
                }
            }

            if (evenNum == oddNum)
                Console.WriteLine($"Yes Sum = {evenNum}");

            else if (evenNum != oddNum)
                Console.WriteLine($"No Diff = {Math.Abs(evenNum - oddNum)}");

        }
    }
}