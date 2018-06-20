using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[] commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            nums.Take(commands[0]).ToList();
            nums.RemoveRange(0, commands[1]);
            Console.WriteLine((nums.Contains(commands[2])) ? "YES!" : "NO!");
        }
    }
}