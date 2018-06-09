using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int daljina = int.Parse(Console.ReadLine());
            int shirochina = int.Parse(Console.ReadLine());
            double visochina = double.Parse(Console.ReadLine());
            double cenaMetar = double.Parse(Console.ReadLine());
            double tegloKvMetar = double.Parse(Console.ReadLine());

            int daljinaNaMrejata = 2 * daljina + 2 * shirochina;
            double cenaNaMrejata = daljinaNaMrejata * cenaMetar;
            double ploshtaNaMrejata = daljinaNaMrejata * visochina;
            double teglotoNaMrejata = ploshtaNaMrejata * tegloKvMetar;

            Console.WriteLine(daljinaNaMrejata);
            Console.WriteLine($"{cenaNaMrejata:f2}");
            Console.WriteLine($"{teglotoNaMrejata:f3}");
        }
    }
}
