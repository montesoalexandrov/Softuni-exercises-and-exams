using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            nums.Sort();
            int[] count = new int[1001];
            for (int i = 0; i < nums.Count; i++)
            {
                count[nums[i]]++;
            }
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] != 0)
                {
                    Console.WriteLine($"{i} -> {count[i]}");
                }
            }
        }
    }
}