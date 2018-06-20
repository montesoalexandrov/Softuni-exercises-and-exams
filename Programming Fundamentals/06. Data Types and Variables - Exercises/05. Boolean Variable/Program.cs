using System;

namespace _05.Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            bool boolean = bool.Parse(str);
            if (boolean == true) { Console.WriteLine("Yes"); }
            else { Console.WriteLine("No"); }
        }
    }
}
