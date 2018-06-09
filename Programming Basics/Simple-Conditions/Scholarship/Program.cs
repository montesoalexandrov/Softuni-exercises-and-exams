using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            var dohod = double.Parse(Console.ReadLine());
            var sredenUspeh = double.Parse(Console.ReadLine());
            var minRabZaplata = double.Parse(Console.ReadLine());

            var socStipendiq = minRabZaplata * 0.35;
            var stipOtlUspeh = sredenUspeh * 25;

            if (socStipendiq > stipOtlUspeh)
            {
                if ((dohod < minRabZaplata && sredenUspeh >= 4.50) || (dohod < minRabZaplata && sredenUspeh >= 4.50) || (dohod < minRabZaplata && sredenUspeh >= 5.50))
                    Console.WriteLine("You get a Social scholarship " + Math.Floor(socStipendiq) + " BGN");
                else if ((dohod < minRabZaplata && sredenUspeh >= 5.50) || (sredenUspeh >= 5.50))
                    Console.WriteLine("You get a scholarship for excellent results " + Math.Floor(stipOtlUspeh) + " BGN");
                else if ((dohod > minRabZaplata && sredenUspeh < 5.50) || dohod < minRabZaplata && sredenUspeh < 4.50)
                    Console.WriteLine("You cannot get a scholarship!");
            }

            else if (stipOtlUspeh > socStipendiq)
            {
                if ((dohod < minRabZaplata && sredenUspeh >= 4.50 && sredenUspeh < 5.50) || (dohod < minRabZaplata && sredenUspeh >= 4.50 && sredenUspeh < 5.50))
                    Console.WriteLine("You get a Social scholarship " + Math.Floor(socStipendiq) + " BGN");
                else if ((dohod < minRabZaplata && sredenUspeh >= 5.50) || (sredenUspeh >= 5.50))
                    Console.WriteLine("You get a scholarship for excellent results " + Math.Floor(stipOtlUspeh) + " BGN");
                else if ((dohod > minRabZaplata && sredenUspeh < 5.50) || dohod < minRabZaplata && sredenUspeh < 4.50)
                    Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
