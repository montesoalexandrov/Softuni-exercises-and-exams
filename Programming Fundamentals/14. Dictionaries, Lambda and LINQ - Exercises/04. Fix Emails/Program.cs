using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var dict = new Dictionary<string, string>();
        var name = Console.ReadLine();
        while (name != "stop")
        {
            var email = Console.ReadLine();
            var domain = String.Empty;
            for (int i = email.Length - 2; i < email.Length; i++)
            {
                domain += email[i];
            }
            if (domain == "bg")
            {
                dict.Add(name, email);
            }
            name = Console.ReadLine();
        }
        foreach (var p in dict)
        {
            Console.WriteLine($"{p.Key} -> {p.Value}");
        }
    }
}
