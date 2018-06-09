using System;

namespace Футболен_турнир
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            double fans = double.Parse(Console.ReadLine());

            double attendanceA = 0;
            double attendanceB = 0;
            double attendanceV = 0;
            double attendanceG = 0;

            for (int i = 0; i < fans; i++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    attendanceA += 1;
                }

                else if (sector == "B")
                {
                    attendanceB += 1;
                }

                else if (sector == "V")
                {
                    attendanceV += 1;
                }

                else if (sector == "G")
                {
                    attendanceG += 1;
                }
            }

            double attedance = (fans / capacity) * 100;

            Console.WriteLine($"{attendanceA / fans * 100:f2}%");
            Console.WriteLine($"{attendanceB / fans * 100:f2}%");
            Console.WriteLine($"{attendanceV / fans * 100:f2}%");
            Console.WriteLine($"{attendanceG / fans * 100:f2}%");
            Console.WriteLine($"{attedance:f2}%");
        }
    }
}
