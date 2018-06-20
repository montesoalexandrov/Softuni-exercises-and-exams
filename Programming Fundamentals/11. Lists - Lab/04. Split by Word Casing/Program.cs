using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Split_by_Word_Casing
{
    class Progra
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();
            foreach (var test in text)
            {
                if (test.All(char.IsLower))
                {
                    lowerCase.Add(test);
                }
                else if (test.All(char.IsUpper))
                {
                    upperCase.Add(test);
                }
                else
                {
                    mixedCase.Add(test);
                }
            }
            Console.WriteLine($"Lower-case: {String.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {String.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {String.Join(", ", upperCase)}");
        }
    }
}