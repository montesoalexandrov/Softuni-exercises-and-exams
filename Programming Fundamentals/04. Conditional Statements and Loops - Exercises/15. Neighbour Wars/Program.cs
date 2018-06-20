using System;

namespace _15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoAtt = int.Parse(Console.ReadLine());
            int goshoAtt = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;

            int rounds = 0;

            for (int i = 1; i <= 100; i++)
            {
                rounds++;

                if (i % 2 != 0)
                {
                    goshoHealth -= peshoAtt;

                    if (goshoHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {rounds}th round.");
                        break;
                    }

                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                }

                else
                {
                    peshoHealth -= goshoAtt;

                    if (peshoHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {rounds}th round.");
                        break;
                    }

                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }

                if (rounds % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
            }
        }
    }
}
