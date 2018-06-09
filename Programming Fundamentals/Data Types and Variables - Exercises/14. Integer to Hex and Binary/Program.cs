using System;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string toHexa = Convert.ToString(number, 16).ToUpper();
            string toBinary = Convert.ToString(number, 2).ToUpper();

            Console.WriteLine($"{toHexa}\n{toBinary}");
        }
    }
}
