using System;
using System.Collections.Generic;
using System.Linq;

public class Palindromes
{
    public static void Main()
    {
        var text = Console.ReadLine().Split(new char[] { ' ', '.', ',', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

        var list = new List<string>();

        foreach (var word in text)
        {
            if (word.SequenceEqual(word.Reverse()))
            {
                list.Add(word);
            }
        }
        Console.WriteLine(String.Join(", ", list.OrderBy(a => a).Distinct()));
    }
}