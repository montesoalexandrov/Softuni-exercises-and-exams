using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counterPoor = 0;
            int counterSatisfactory = 0;
            int counterGoodMark = 0;
            int counterVerryGoodMark = 0;
            int counterExcellenMark = 0;

            for (int i = 0; i < n; i++)
            {
                double ocenka = double.Parse(Console.ReadLine());

                if (ocenka <= 22.5)
                {
                    counterPoor += 1;

                }

                else if (ocenka > 22.5 && ocenka <= 40.5)
                {
                    counterSatisfactory += 1;
                }

                else if (ocenka > 40.5 && ocenka <= 58.5)
                {
                    counterGoodMark += 1;
                }

                else if (ocenka > 58.5 && ocenka <= 76.5)
                {
                    counterVerryGoodMark += 1; ;
                }

                else if (ocenka > 76.5 && ocenka <= 100)
                {
                    counterExcellenMark += 1;
                }
            }

            Console.WriteLine($"{(counterPoor * 100.00) / n:f2}% poor marks");
            Console.WriteLine($"{(counterSatisfactory * 100.00) / n:f2}% satisfactory marks");
            Console.WriteLine($"{(counterGoodMark * 100.00) / n:f2}% good marks");
            Console.WriteLine($"{(counterVerryGoodMark * 100.00) / n:f2}% very good marks");
            Console.WriteLine($"{(counterExcellenMark * 100.00) / n:f2}% excellent marks");
        }
    }
}

