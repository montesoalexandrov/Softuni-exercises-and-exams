using System;

namespace Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            for (int i = 0; n - 1 > i; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (min > currentNumber)
                {
                    min = currentNumber;
                }
            }
            Console.WriteLine(min);
        }
    }
}
