using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var cenaEskurziq = double.Parse(Console.ReadLine());
            var broiPazeli = double.Parse(Console.ReadLine());
            var broiGovKukli = double.Parse(Console.ReadLine());
            var broiPlushMechenca = double.Parse(Console.ReadLine());
            var broiMinioni = double.Parse(Console.ReadLine());
            var broiKamioncheta = double.Parse(Console.ReadLine());

            var pazel = 2.60;
            var govKukla = 3;
            var PlushMeche = 4.10;
            var Minion = 8.20;
            var Kamionche = 2;

            var suma = broiPazeli * pazel + broiGovKukli * govKukla + broiPlushMechenca * PlushMeche + broiMinioni * Minion + broiKamioncheta * Kamionche;
            var broiIgrachki = broiPazeli + broiGovKukli + broiPlushMechenca + broiMinioni + broiKamioncheta;
            var sumaPriOstapka = suma - (suma * 0.25);
            var sledNaemSuma = suma - (suma * 0.10);
            var sledNaemPriOtstapka = sumaPriOstapka - (sumaPriOstapka * 0.10);

            if(broiIgrachki < 50)
            {
                if (sledNaemSuma >= cenaEskurziq) Console.WriteLine($"Yes! {sledNaemSuma - cenaEskurziq:f2} lv left.");
                else if (sledNaemSuma < cenaEskurziq) Console.WriteLine($"Not enough money! {cenaEskurziq - sledNaemSuma:f2} lv needed.");
            }

            else if (broiIgrachki >= 50)
            {
                if (sledNaemPriOtstapka >= cenaEskurziq) Console.WriteLine($"Yes! {sledNaemPriOtstapka - cenaEskurziq:f2} lv left.");
                else if (sledNaemPriOtstapka < cenaEskurziq) Console.WriteLine($"Not enough money! {cenaEskurziq - sledNaemPriOtstapka:f2} lv needed.");
            }
        }
    }
}
