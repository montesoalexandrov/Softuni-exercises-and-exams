using System;

namespace Grandpa_Stavri
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double liter = 0;
            double degrees = 0;
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                double kolRakiq = double.Parse(Console.ReadLine());
                double gradusRakiq = double.Parse(Console.ReadLine());

                double currentSum = 0;

                liter += kolRakiq;

                currentSum = kolRakiq * gradusRakiq;
                sum += currentSum;
            }
            degrees = sum / liter;

            Console.WriteLine($"Liter: {liter:f2}");
            Console.WriteLine($"Degrees: {degrees:f2}");

            if (degrees < 38)
            { Console.WriteLine("Not good, you should baking!"); }
            else if (degrees >= 38 && degrees <= 42)
            { Console.WriteLine("Super!"); }
            else if (degrees > 42)
            { Console.WriteLine("Dilution with distilled water!"); }
        }
    }
}

