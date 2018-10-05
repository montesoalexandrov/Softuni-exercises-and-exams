using System;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var regularGuest = new HashSet<string>();
            var vipGuests = new HashSet<string>();

            var input = String.Empty;

            while ((input = Console.ReadLine()) != "PARTY")
            {
                if (input.Length != 8)
                {
                    continue;
                }
                else if (char.IsDigit(input[0]))
                {
                    vipGuests.Add(input);
                }
                else
                {
                    regularGuest.Add(input);
                }
            }

            while ((input = Console.ReadLine()) != "END")
            {
                if (char.IsDigit(input[0]))
                {
                    vipGuests.Remove(input);
                }
                else
                {
                    regularGuest.Remove(input);
                }
            }

            Console.WriteLine($"{vipGuests.Count + regularGuest.Count}");
            foreach (var guest in vipGuests)
            {
                Console.WriteLine(guest);
            }

            foreach (var guest in regularGuest)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
