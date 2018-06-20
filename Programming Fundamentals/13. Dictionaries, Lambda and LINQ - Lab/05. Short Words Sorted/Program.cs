using System;
using System.Linq;

namespace _05._Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower()
                .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length < 5)
                .Distinct()
                .OrderBy(x => x)
                .ToArray();
            Console.WriteLine(String.Join(", ", text));
        }
    }
}