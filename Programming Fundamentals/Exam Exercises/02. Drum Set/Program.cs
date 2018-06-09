using System;
using System.Linq;

namespace _02._Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            var drumSet = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var currentDrumSet = drumSet.ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if(command == "Hit it again, Gabsy!")
                {
                    break;
                }

                int hitPower = int.Parse(command);

                for (int i = 0; i < currentDrumSet.Count; i++)
                {
                    if(currentDrumSet[i] - hitPower <= 0)
                    {
                        if (money >= drumSet[i] * 3)
                        {
                            money -= drumSet[i] * 3;
                            currentDrumSet[i] = drumSet[i];
                            continue;
                        }
                        else
                        {
                            currentDrumSet.Remove(currentDrumSet[i]);
                            drumSet.Remove(drumSet[i]);
                            i -= 1;
                            continue;
                        }
                    }
                    currentDrumSet[i] -= hitPower;
                }
            }
            Console.WriteLine(String.Join(" ", currentDrumSet));
            Console.WriteLine($"Gabsy has {money:f2}lv.");
        }
    }
}