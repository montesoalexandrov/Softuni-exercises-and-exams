using System;
using System.Text.RegularExpressions;
using System.Linq;

public class Example
{
    public static void Main()
    {
        string pattern = @"\+359(\s|-)2\1\d{3}\1\d{4}(?!\d)";

        string numbers = Console.ReadLine();

        var numbersMatches = Regex.Matches(numbers, pattern);

        var matchedNumbers = numbersMatches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

        Console.WriteLine(string.Join(", ", matchedNumbers));
    }
}