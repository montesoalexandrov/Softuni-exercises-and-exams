using System;

namespace Energy_Loss
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());

            double energy = 0;
            double energySum = 100 * dancers * days;
            double freshEnergyForDancer = 0;

            for (int i = 1; i <= days; i++)
            {
                int hours = int.Parse(Console.ReadLine());

                if (i % 2 == 0 && hours % 2 == 0)
                {
                    energy += 68;
                }

                else if (i % 2 != 0 && hours % 2 == 0)
                {
                    energy += 49;
                }

                else if (i % 2 == 0 && hours % 2 != 0)
                {
                    energy += 65;
                }

                else if (i % 2 != 0 && hours % 2 != 0)
                {
                    energy += 30;
                }
            }

            double energyLeft = energySum - (energy * dancers);
            freshEnergyForDancer = energyLeft / dancers / days;

            if (freshEnergyForDancer <= 50)
            {
                Console.WriteLine($"They are wasted! Energy left: {freshEnergyForDancer:f2}");
            }

            else
            {
                Console.WriteLine($"They feel good! Energy left: {freshEnergyForDancer:f2}");
            }
        }
    }
}