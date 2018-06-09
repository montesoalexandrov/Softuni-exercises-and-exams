namespace Bomb_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class BombNumbers
    {
        public static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[] bombAndPower = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < nums.Count; i++)
            {
                int bomb = bombAndPower[0];
                int power = bombAndPower[1];
                if (nums[i] == bomb)
                {
                    int neighborsNums = (i - power < 0) ? 0 : (i - power);
                    int j = 0;
                    while (neighborsNums < nums.Count && j < (2 * power) + 1)
                    {
                        nums.RemoveAt(neighborsNums);
                        j++;
                    }
                    i = 0;
                }
            }
            Console.WriteLine(nums.Sum());
        }
    }
}