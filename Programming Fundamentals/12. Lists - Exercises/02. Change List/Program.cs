using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var command = Console.ReadLine().Split(' ').ToArray();
            while (command[0] != "Odd" && command[0] != "Even")
            {
                if (command[0] == "Delete")
                {
                    int index = int.Parse(command[1]);
                    for (int i = 0; i < nums.Count; i++)
                    {
                        nums.Remove(index);
                    }
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[2]);
                    int position = int.Parse(command[1]);
                    nums.Insert(index, position);
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
            List<int> oddNums = new List<int>();
            List<int> evenNums = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    oddNums.Add(nums[i]);
                }
                else
                {
                    evenNums.Add(nums[i]);
                }
            }
            if (command[0] == "Odd")
            {
                Console.WriteLine(String.Join(" ", oddNums));
            }
            else
            {
                Console.WriteLine(String.Join(" ", evenNums));
            }
        }
    }
}