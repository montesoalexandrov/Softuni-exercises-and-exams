using System;

namespace _04.Grandpa_Stavri
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double liter = 0;
            double degrees = 0;
            double total = 0;
            double total2 = 0;

            for (int i = 0; i < n; i++)
            {
                double kolichestvoRakiq = double.Parse(Console.ReadLine());
                double gradusRakiq = double.Parse(Console.ReadLine());

                liter += kolichestvoRakiq;
                total = kolichestvoRakiq * gradusRakiq;
                total2 += total;
            }
            degrees = total2 / liter;

            Console.WriteLine($"Liter: {liter:f2}");
            Console.WriteLine($"Degrees: {degrees:f2}");

            if (degrees < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            
            else if (degrees >= 38 && degrees <= 42)
            {
                Console.WriteLine("Super!");
            }

            else if (degrees > 42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
