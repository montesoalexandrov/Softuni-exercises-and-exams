using System;

namespace Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            var stapki = double.Parse(Console.ReadLine());
            var tanciori = double.Parse(Console.ReadLine());
            var dni = double.Parse(Console.ReadLine());

            var stapkiNaDen = Math.Ceiling((stapki / dni) / stapki * 100);
            var PrStNaVsTancior = stapkiNaDen / tanciori;

            if (stapkiNaDen <= 13) Console.WriteLine($"Yes, they will succeed in that goal! {(PrStNaVsTancior):f2}%.");
            else if (stapkiNaDen > 13) Console.WriteLine($"No, They will not succeed in that goal! Required {(PrStNaVsTancior):f2}% steps to be learned per day.");
        }
    }
}
