using System;
using System.Linq;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> appendAndPrint = n => Console.WriteLine($"Sir {n}");
            Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(appendAndPrint);
        }
    }
}