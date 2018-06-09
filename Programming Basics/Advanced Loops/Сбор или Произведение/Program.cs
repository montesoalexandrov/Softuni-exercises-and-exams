using System;

namespace Сбор_или_Произведение
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlNumber = int.Parse(Console.ReadLine());

            int count = 0;

            for (int a = 1; a <= 30; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    for (int c = 1; c <= 30; c++)
                    {
                        var sum = a + b + c;
                        var product = a * b * c;

                        if (a < b && b < c && sum == controlNumber)
                        {
                            Console.WriteLine($"{a} + {b} + {c} = {sum}");
                            count++;
                        }

                        if (a > b && b > c && product == controlNumber)
                        {
                            Console.WriteLine($"{a} * {b} * {c} = {product}");
                            count++;
                        }
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No!");
            }
        }
    }
}