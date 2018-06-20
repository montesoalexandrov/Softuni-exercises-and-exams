using System;

namespace парична_награда
{
    class Program
    {
        static void Main(string[] args)
        {
            int parts = int.Parse(Console.ReadLine());
            double moneyForPoint = double.Parse(Console.ReadLine());

            double prise = 0;

            for (int i = 1; i <= parts; i++)
            {
                int points = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    prise += points * 2;
                }

                else
                {
                    prise += points;
                }
            }

            Console.WriteLine($"The project prize was {moneyForPoint * prise:f2} lv.");
        }
    }
}
