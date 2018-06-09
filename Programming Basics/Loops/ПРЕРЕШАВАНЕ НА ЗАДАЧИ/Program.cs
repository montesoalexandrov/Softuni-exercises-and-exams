using System;

namespace ПРЕРЕШАВАНЕ_НА_ЗАДАЧИ
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int maxSum = 0;
            int previousSum = 0;

            for (int i = 0; i < n; i++)
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());

                sum = first + second;

                if (i == 0)
                {
                    maxSum = sum;
                    previousSum = sum;
                }

                else if (i != 0)
                {

                    if (maxSum < sum)
                    {
                        maxSum = sum;
                    }

                    else
                    {
                        previousSum = sum;
                    }
                }
            }

            if (maxSum == previousSum)
            {
                Console.WriteLine($"Yes, value={sum}");
            }

            else
            {
                Console.WriteLine($"No, maxdiff={maxSum - previousSum}");
            }
        }
    }
}