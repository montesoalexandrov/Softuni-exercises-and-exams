using System;
using System.Linq;
namespace _04.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrOfNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool areNotEqual = true;

            for (int a = 0; a < arrOfNums.Length; a++)
            {
                for (int b = a + 1; b < arrOfNums.Length; b++)
                {
                    int sum = arrOfNums[a] + arrOfNums[b];
                    if (arrOfNums.Contains(sum))
                    {
                        Console.WriteLine($"{arrOfNums[a]} + {arrOfNums[b]} == {sum}");
                        if (areNotEqual)
                            areNotEqual = false;
                    }
                }
            }
            if (areNotEqual)
            {
                Console.WriteLine("No");
            }
        }
    }
}