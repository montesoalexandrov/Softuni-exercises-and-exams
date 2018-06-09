using System;

namespace Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            while (true)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());

                    if (number % 2 != 0)
                    {
                        Console.WriteLine("The number is not even.");
                        Console.Write("Enter even number: ");
                    }
                    else
                    {
                        break;
                    }
                }

                catch (Exception)
                {
                    Console.WriteLine("Invalid number!");
                    Console.Write("Enter even number: ");
                }
            }
            Console.WriteLine($"Even number entered: {number}");
        }
    }
}
