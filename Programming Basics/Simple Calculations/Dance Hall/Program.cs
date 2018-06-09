using System;

namespace Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            var L = double.Parse(Console.ReadLine());
            var W = double.Parse(Console.ReadLine());
            var A = double.Parse(Console.ReadLine());

            var goleminaZala = (L * 100) * (W * 100);
            var goleminaGarderob = (A * 100) * (A * 100);
            var goleminaPeika = goleminaZala / 10;
            var freeSpace = goleminaZala - goleminaGarderob - goleminaPeika;
            var numberOfDancers = freeSpace / (40 + 7000);

            Console.WriteLine(Math.Floor(numberOfDancers));
        }
    }
}
