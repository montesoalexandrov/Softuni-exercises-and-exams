using System;

namespace Powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num = 1;

            Console.WriteLine(num);

            for (int i = 0; i < n; i++)    
            {
                num = num * 2;

                Console.WriteLine(num);

                //int n = int.Parse(Console.ReadLine());
                //double num = 0.5;
                //
                //for (int i = 0; i <= n; i++)
                //{
                //    Console.WriteLine(num * 2);
                //    num += num;
                //}
            }
        }
    }
}
