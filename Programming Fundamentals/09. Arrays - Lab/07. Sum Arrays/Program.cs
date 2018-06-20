using System;
using System.Linq;
namespace _07.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var maxArr = Math.Max(arr1.Length, arr2.Length);
            var sumArr = new int[maxArr];

            for (int i = 0; i < maxArr; i++)
            {
                sumArr[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
                Console.Write($"{sumArr[i]} ");
            }
        }
    }
}
