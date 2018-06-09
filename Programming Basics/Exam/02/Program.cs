using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            double kolDomatiKg = double.Parse(Console.ReadLine());
            int broiKasetki = int.Parse(Console.ReadLine());
            int broiBurkani = int.Parse(Console.ReadLine());

            double obshtoKgLutenica = kolDomatiKg / 5;
            double burkani = obshtoKgLutenica / 0.535;
            double kasetki = burkani / broiBurkani;

            double sumKasetki = Math.Truncate(kasetki - broiKasetki);
            double sumBurkani = Math.Truncate(burkani - (broiKasetki * broiBurkani));

            Console.WriteLine($"Total lutenica: {Math.Truncate(obshtoKgLutenica)} kilograms.");

            if (kasetki >= broiKasetki)
            {
                Console.WriteLine($"{Math.Abs(sumKasetki)} boxes left.");
                Console.WriteLine($"{Math.Abs(sumBurkani)} jars left.");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(sumKasetki)} more boxes needed.");
                Console.WriteLine($"{Math.Abs(sumBurkani)} more jars needed.");
            }
        }
    }
}
