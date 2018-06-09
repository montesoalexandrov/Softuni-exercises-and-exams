using System;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }
                else if (input == "decrease")
                {
                    for (int i = 0; i < nums.Length; i++)
                    {
                        nums[i] -= 1;
                    }
                }
                else
                {
                    var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var command = tokens[0];
                    var index1 = int.Parse(tokens[1]);
                    var index2 = int.Parse(tokens[2]);

                    if (command == "swap")
                    {
                        long temp = nums[index1];
                        nums[index1] = nums[index2];
                        nums[index2] = temp;
                    }
                    else if (command == "multiply")
                    {
                        nums[index1] = nums[index1] * nums[index2];
                    }
                }
            }
            Console.WriteLine(String.Join(", ", nums));
        }
    }
}