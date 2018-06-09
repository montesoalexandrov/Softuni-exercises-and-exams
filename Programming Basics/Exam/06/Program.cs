using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int f = 1; f <= 9; f++)
            {
                for (int s = 1; s <= 9; s++)
                {
                    for (int t = 1; t <= 9; t++)
                    {
                        for (int ff = 1; ff <= 9; ff++)
                        {
                            if (f + s == t + ff && n % (f+s) == 0)
                                Console.Write($"{f}{s}{t}{ff} ");
                        }
                    }
                }
            }
        }
    }
}
