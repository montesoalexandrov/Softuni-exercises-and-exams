using System;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    count++;
                    sum = sum + (3 * (i * j));

                    if (sum >= maxSum)
                    {
                        break;
                    }
                }
                if (sum >= maxSum)
                {
                    break;
                }
            }
            {
                if (sum >= maxSum)
                {
                    Console.WriteLine($"{count} combinations");
                    Console.WriteLine($"Sum: {sum} >= {maxSum}");
                }
                else
                {
                    Console.WriteLine($"{count} combinations");
                    Console.WriteLine($"Sum: {sum}");
                }
            }
        }
    }
}
