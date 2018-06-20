using System;

namespace _06.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int minNum = Math.Min(n, n2);
            int maxNum = Math.Max(n, n2);

            for (int i = minNum; i <= maxNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
