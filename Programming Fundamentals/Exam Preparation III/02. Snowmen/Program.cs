using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


            while (nums.Count > 1)
            {
                var losers = new List<int>();

                for (int attacker = 0; attacker < nums.Count; attacker++)
                {
                    if(nums.Count - losers.Count == 1)
                    {
                        break;
                    }

                    int target = nums[attacker];
                    
                    if (target > nums.Count-1)
                    {
                        target %= nums.Count;
                    }

                    int diff = Math.Abs(attacker - target);


                    if (nums[attacker] == -1)
                    {
                        continue;
                    }

                    if (attacker == target)
                    {
                        losers.Add(attacker);
                        Console.WriteLine($"{attacker} performed harakiri");
                        nums[attacker] = -1;
                    }
                    else if (diff % 2 == 0)
                    {
                        losers.Add(target);
                        Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                        nums[target] = -1;
                    }
                    else
                    {
                        losers.Add(attacker);
                        Console.WriteLine($"{attacker} x {target} -> {target} wins");
                        nums[attacker] = -1;
                    }
                    losers = losers
                        .Distinct()
                        .ToList();
                }

                nums = nums
                    .Where(n => n != -1)
                    .ToList();
            }
        }
    }
}