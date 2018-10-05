using System;
using System.Collections.Generic;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new Dictionary<string, int>();
            var input = Console.ReadLine().Split();
            foreach (var num in input)
            {
                if (!nums.ContainsKey(num))
                {
                    nums.Add(num, 1);
                }
                else
                {
                    nums[num]++;
                }
            }

            foreach (var num in nums)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}