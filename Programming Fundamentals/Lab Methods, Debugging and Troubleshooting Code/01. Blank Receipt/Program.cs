using System;

namespace _01.Blank_Receipt
{
    class Program
    {
        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT\n------------------------------");
        }

        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________\nReceived by___________________");
        }

        static void PrintFooter()
        {
            Console.WriteLine($"------------------------------\n\u00A9 SoftUni");
        }
        static void Main(string[] args)
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
    }
}