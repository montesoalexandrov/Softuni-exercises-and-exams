using System;
using System.Linq;
namespace _09.Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            ExtractMiddle(array);
        }
        static void ExtractMiddle(int[] array)
        {
            int n = array.Length;

            if (array.Length == 1)
            {
                Console.WriteLine(array[0]);
            }
            else if (array.Length % 2 == 0)
            {
                Console.WriteLine($"{array[n / 2 - 1]}, {array[n / 2]}");
            }
            else
            {
                Console.WriteLine($"{array[n / 2 - 1]}, {array[n / 2]}, {array[n / 2 + 1]}");
            }
        }
    }
}