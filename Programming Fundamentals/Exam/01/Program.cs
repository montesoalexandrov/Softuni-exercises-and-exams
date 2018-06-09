using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double sabresPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double freeBelts = studentsCount / 6;

            double sabres = Math.Ceiling(studentsCount + (studentsCount * 0.10));
            double sabresSum = sabresPrice * sabres;
            double robesSum = robesPrice * studentsCount;
            double beltsSum = beltsPrice * (studentsCount - freeBelts);

            double sum = sabresSum + robesSum + beltsSum;

            if (sum <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {sum - money:f2}lv more.");
            }
        }
    }
}