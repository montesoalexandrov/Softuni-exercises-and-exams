using System;

public class Program
{
    public static void Main()
    {
        var first = Console.ReadLine();
        var second = Console.ReadLine();
        var result = new DateModifier(first, second);
        result.DaysDifference(result);
    }
}