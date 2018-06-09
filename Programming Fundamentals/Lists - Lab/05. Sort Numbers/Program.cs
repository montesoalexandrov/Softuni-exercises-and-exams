using System;
using System.Linq;

namespace _05.Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToList();
            nums.Sort();
            Console.WriteLine(String.Join(" <= ", nums));
        }
    }
}