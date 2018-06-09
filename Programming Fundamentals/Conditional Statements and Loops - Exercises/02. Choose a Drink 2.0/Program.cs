using System;

namespace _02.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());
            double sum = 0.00;

            if (profession == "Athlete")
            {
                sum = quantity * 0.70;
                Console.WriteLine($"The {profession} has to pay {sum:f2}.");
            }

            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                sum = quantity * 1.00;
                Console.WriteLine($"The {profession} has to pay {sum:f2}.");
            }

            else if (profession == "SoftUni Student")
            {
                sum = quantity * 1.70;
                Console.WriteLine($"The {profession} has to pay {sum:f2}.");
            }

            else
            {
                sum = quantity * 1.20;
                Console.WriteLine($"The {profession} has to pay {sum:f2}.");
            }
        }
    }
}
