using System;
using System.Collections.Generic;
using System.Linq;

class User_Logs
{
    static void Main(string[] args)
    {
        var ipsAndUsers =
            new SortedDictionary<string, Dictionary<string, int>>();
        var input = Console.ReadLine().Split('=', ' ').ToArray();
        while (input[0] != "end")
        {
            var user = input[5];
            var ip = input[1];
            if (!ipsAndUsers.ContainsKey(user))
            {
                ipsAndUsers[user] = new Dictionary<string, int>();
            }
            if (!ipsAndUsers[user].ContainsKey(ip))
            {
                ipsAndUsers[user][ip] = 1;
            }
            else
            {
                ipsAndUsers[user][ip] += 1;
            }
            input = Console.ReadLine().Split('=', ' ').ToArray();
        }
        foreach (var printUsers in ipsAndUsers)
        {
            int n = 0;
            var user = printUsers.Key;
            Console.WriteLine($"{user}:");
            foreach (var printIps in printUsers.Value)
            {
                n += 1;
                var count = printIps.Value;
                var ip = printIps.Key;
                if (n == ipsAndUsers[user].Values.Count)
                {
                    Console.Write($"{ip} => {count}.");
                }
                else
                {
                    Console.Write($"{ip} => {count}, ");
                }
            }
            Console.WriteLine();
        }
    }
}