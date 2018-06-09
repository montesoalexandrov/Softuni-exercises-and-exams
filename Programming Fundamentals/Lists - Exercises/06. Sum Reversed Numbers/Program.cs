using System;
using System.Linq;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int reveresed = 0;
                while (nums[i] > 0)
                {
                    int rev = nums[i] % 10;
                    reveresed = reveresed * 10 + rev;
                    nums[i] = nums[i] / 10;
                }
                sum += reveresed;
            }
            Console.WriteLine(sum);
        }
    }
}