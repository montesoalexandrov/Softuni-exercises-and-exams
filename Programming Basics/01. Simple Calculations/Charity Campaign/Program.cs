using System;

namespace Благотворителна_кампания
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = double.Parse(Console.ReadLine());
            var sladkari = double.Parse(Console.ReadLine());
            var torti = double.Parse(Console.ReadLine());
            var gofreti = double.Parse(Console.ReadLine());
            var palachinki = double.Parse(Console.ReadLine());

            var sumaTorti = torti * 45;
            var sumaGofreti = gofreti * 5.80;
            var sumaPalachinki = palachinki * 3.20;
            var sumaZaDen = (sumaTorti + sumaGofreti + sumaPalachinki) * sladkari;
            var sumaKampaniq = sumaZaDen * days;
            var sumaSledRazhodi = sumaKampaniq - (sumaKampaniq / 8);

            Console.WriteLine("{0:f2}", sumaSledRazhodi);
        }
    }
}
