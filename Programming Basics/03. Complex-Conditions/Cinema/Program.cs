using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeProjection = Console.ReadLine().ToLower();
            var r = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            var income = 0.00;

            if (typeProjection == "premiere") income = (12.00 * r * c);
            else if (typeProjection == "normal") income = (7.50 * r * c);
            else if (typeProjection == "discount") income = (5.00 * r * c);

            Console.WriteLine("{0:f2}", income + " leva");
        }
    }
}
