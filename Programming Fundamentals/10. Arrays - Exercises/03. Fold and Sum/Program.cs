using System;
using System.Linq;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = array.Length / 4;
            int[] upperRow = new int[k * 2];
            int[] lowerRow = new int[k * 2];
            int[] result = new int[k * 2];
            for (int i = 0; i < k; i++)
            {
                upperRow[i] = array[k - 1 - i];
                upperRow[upperRow.Length + i - k] = array[array.Length - 1 - i];
                lowerRow[i] = array[k + i];
                lowerRow[k + i] = array[k * 2 + i];
            }
            for (int i = 0; i < upperRow.Length; i++)
            {
                result[i] = upperRow[i] + lowerRow[i];
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}