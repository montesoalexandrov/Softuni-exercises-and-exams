using System;
using System.Linq;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            ReservedOrder(num);
        }
        static void ReservedOrder(string num)
        {
            Console.WriteLine(new string(num.Reverse().ToArray()));
            return;
        }
    }
}
