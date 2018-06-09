using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var words = Console.ReadLine().ToLower().Split().ToArray();
        var dict = new Dictionary<string, int>();
        foreach (var word in words)
        {
            if (dict.ContainsKey(word))
            {
                dict[word]++;
            }
            else
            {
                dict[word] = 1;
            }
        }
        var output = new List<string>();
        foreach (var p in dict)
        {
            if (p.Value % 2 == 1)
            {
                output.Add(p.Key);
            }
        }
        Console.WriteLine(String.Join(", ", output));
    }
}