using System;

namespace _01.Exam___Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int currentPokePower = pokePower;
            int count = 0;

            while (true)
            {
                if (currentPokePower < distance)
                {
                    break;
                }

                if (currentPokePower == pokePower / 2)
                {
                    if (currentPokePower >= exhaustionFactor && exhaustionFactor != 0)
                    {
                        currentPokePower /= exhaustionFactor;

                        if (currentPokePower < distance)
                        {
                            break;
                        }
                        else
                        {
                            currentPokePower -= distance;
                            count++;
                        }
                    }
                    else
                    {
                        if (currentPokePower < distance)
                        {
                            break;
                        }
                        else
                        {
                            currentPokePower -= distance;
                            count++;
                        }
                    }
                }
                else
                {
                    currentPokePower -= distance;
                    count++;
                }
            }
            Console.WriteLine(currentPokePower);
            Console.WriteLine(count);
        }
    }
}