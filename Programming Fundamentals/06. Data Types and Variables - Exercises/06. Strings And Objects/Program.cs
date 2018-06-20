using System;

namespace _06.Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            string all = string.Concat(hello + " " + world);
            Console.WriteLine(all);
        }
    }
}
