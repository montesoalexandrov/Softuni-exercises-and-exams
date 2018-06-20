using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            nums.Sort();
            nums.Reverse();
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                if (Math.Sqrt(nums[i]) == Math.Truncate(Math.Sqrt(nums[i])))
                    result.Add((nums[i]));
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}