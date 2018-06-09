using System;
using System.Linq;

namespace _01._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            double averageValue = nums.Average();

            nums = nums.OrderByDescending(x => x).ToList();
            int bestNum = nums.First();

            if (bestNum <= averageValue)
            {
                Console.WriteLine($"No");
            }

            else if (nums.Count >= 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (nums[i] > averageValue)
                    {
                        Console.Write($"{nums[i]} ");
                    }
                }
            }

            else
            {
                foreach (var num in nums)
                {
                    if (num > averageValue)
                    {
                        Console.Write($"{num} ");
                    }
                }
            }
        }
    }
}