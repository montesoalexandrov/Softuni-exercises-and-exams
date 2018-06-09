using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string pattern = @"(\b[A-Z]{1}[a-z]+) ([A-Z]{1}[a-z]+\b)";
        string names = Console.ReadLine();

        MatchCollection matchedNames = Regex.Matches(names, pattern);

        foreach (Match name in matchedNames)
        {
            Console.Write($"{name.Value} ");
        }
        Console.WriteLine();
    }
}