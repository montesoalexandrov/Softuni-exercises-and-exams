using System;

namespace Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            var cenaUiski = double.Parse(Console.ReadLine());
            var kolichestvoBira = double.Parse(Console.ReadLine());
            var kolichestvoVino = double.Parse(Console.ReadLine());
            var kolichestvoRakiq = double.Parse(Console.ReadLine());
            var kolichestvoUiski = double.Parse(Console.ReadLine());

            var cenaRakiq = cenaUiski / 2;
            var cenaVino = cenaRakiq - (0.4 * cenaRakiq);
            var cenaBira = cenaRakiq - (0.8 * cenaRakiq);

            var sumaRakiq = kolichestvoRakiq * cenaRakiq;
            var sumaVino = kolichestvoVino * cenaVino;
            var sumaBira = kolichestvoBira * cenaBira;
            var sumaUiski = kolichestvoUiski * cenaUiski;

            var obshtaSuma = sumaBira + sumaRakiq + sumaUiski + sumaVino;

            Console.WriteLine("{0:f2}", obshtaSuma);
        }
    }
}
