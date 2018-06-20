using System;

namespace Final_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            var broiTanciori = double.Parse(Console.ReadLine());
            var broiTochki = double.Parse(Console.ReadLine());
            var sezon = Console.ReadLine().ToLower();
            var mqsto = Console.ReadLine().ToLower();

            if (mqsto == "abroad")
            {
                var nagrada = (broiTanciori * broiTochki) + ((broiTanciori * broiTochki) * 0.50);
                if (sezon == "summer")
                {
                    var nagradaBezRazhodi = nagrada - (nagrada * 0.10);
                    Console.WriteLine($"Charity - {nagradaBezRazhodi - (nagradaBezRazhodi * 0.25):f2}");
                    Console.WriteLine($"Money per dancer - {(nagradaBezRazhodi - (nagradaBezRazhodi * 0.75)) / broiTanciori:f2}");
                }

                else if (sezon == "winter")
                {
                    var nagradaBezRazhodi = nagrada - (nagrada * 0.15);
                    Console.WriteLine($"Charity - {nagradaBezRazhodi - (nagradaBezRazhodi * 0.25):f2}");
                    Console.WriteLine($"Money per dancer - {(nagradaBezRazhodi - (nagradaBezRazhodi * 0.75)) / broiTanciori:f2}");
                }
            }

            else if (mqsto == "bulgaria")
            {
                var nagrada = broiTanciori * broiTochki;
                if (sezon == "summer")
                {
                    var nagradaBezRazhodi = nagrada - (nagrada * 0.05);
                    Console.WriteLine($"Charity - {nagradaBezRazhodi - (nagradaBezRazhodi * 0.25):f2}");
                    Console.WriteLine($"Money per dancer - {(nagradaBezRazhodi - (nagradaBezRazhodi * 0.75)) / broiTanciori:f2}");
                }

                else if (sezon == "winter")
                {
                    var nagradaBezRazhodi = nagrada - (nagrada * 0.08);
                    Console.WriteLine($"Charity - {nagradaBezRazhodi - (nagradaBezRazhodi * 0.25):f2}");
                    Console.WriteLine($"Money per dancer - {(nagradaBezRazhodi - (nagradaBezRazhodi * 0.75)) / broiTanciori:f2}");
                }
            }
        }
    }
}
