using System;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneLv = int.Parse(Console.ReadLine());
            int twoLv = int.Parse(Console.ReadLine());
            int fiveLv = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());
                
            for (int o = 0; o <= oneLv; o++)
            {
                for (int t = 0; t <= twoLv; t++)
                {
                    for (int f = 0; f <= fiveLv; f++)
                    {
                        if (o * 1 + t * 2 + f * 5 == sum)
                            Console.WriteLine($"{o} * 1 lv. + {t} * 2 lv. + {f} * 5 lv. = {sum} lv.");
                    }
                }
            }
        }
    }
}
