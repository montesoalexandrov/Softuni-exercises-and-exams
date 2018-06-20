using System;

namespace Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberTables = double.Parse(Console.ReadLine());
            var p = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());

            var pokrivki = numberTables * (p + 2 * 0.30) * (w + 2 * 0.30);
            var kareta = numberTables * (p / 2) * (p / 2);
            var price = pokrivki * 7 + kareta * 9;

            Console.WriteLine("{0:f2} USD", price);
            Console.WriteLine("{0:f2} BGN", price * 1.85);
        }
    }
}
