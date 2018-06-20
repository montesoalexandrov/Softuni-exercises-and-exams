using System;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > max)
                {
                    max = currentNumber;
                }
            }
            Console.WriteLine(max);
        }
    }
}
