using System;
using System.Linq;

namespace _03._Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var chars = text.Select(c => (int)c).Select(c => $@"\u{c:x4}");

            var result = string.Concat(chars);

            Console.WriteLine(result);
        }
    }
}