using System;

namespace _01.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int daljina = int.Parse(Console.ReadLine());
            int shirochina = int.Parse(Console.ReadLine());
            int visochina = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());

            double obem = daljina * shirochina * visochina;
            double obshtoLitri = obem * 0.001;
            double procentDesetichno = procent * 0.01;
            double litri = obshtoLitri * (1 - procentDesetichno);

            Console.WriteLine($"{litri:f3}");
        }
    }
}
