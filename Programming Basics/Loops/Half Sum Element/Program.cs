using System;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNum = 0;
            int sumWithoutMax = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;

                if (maxNum < currentNumber)
                    maxNum = currentNumber;
            }
            sumWithoutMax = Math.Abs(sum - maxNum);

            if (maxNum == sumWithoutMax)
                Console.WriteLine($"Yes sum = {maxNum}");
            else if (maxNum != sumWithoutMax)
                Console.WriteLine($"No Diff = {Math.Abs(maxNum - sumWithoutMax)}");
        }
    }
}
