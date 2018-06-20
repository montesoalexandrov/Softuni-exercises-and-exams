using System;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; 0 < n; i++)
            {
                int num = n % 10;
                n = n / 10;
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
