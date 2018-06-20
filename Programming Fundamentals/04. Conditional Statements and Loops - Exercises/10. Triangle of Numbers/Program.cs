using System;

namespace _10.Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write("1");

            for (int i = 2; i <= n; i++)
            {
                Console.WriteLine();
                Console.Write("{0} ", i);
                for (int j = 2; j <= i; j++)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
