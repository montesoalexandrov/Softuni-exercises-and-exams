using System;
namespace _03.Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            long[] seq = new long[n];
            seq[0] = 1;

            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                int startIndex = Math.Max(0, i - k);

                for (int j = startIndex; j < i; j++)
                {
                    sum += seq[j];
                }

                seq[i] = sum;
            }

            Console.WriteLine(string.Join(" ", seq));
        }
    }
}
