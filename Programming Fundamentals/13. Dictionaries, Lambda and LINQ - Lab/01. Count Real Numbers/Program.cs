using System;
using System.Collections.Generic;
using System.Linq;

public class CountRealNumbers
{
    public static void Main(string[] args)
    {
        double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
        var dict = new SortedDictionary<double, int>();
        foreach (var num in numbers)
        {
            if (dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else
            {
                dict[num] = 1;
            }
        }
        foreach (var p in dict)
        {
            Console.WriteLine(p.Key + " -> " + p.Value);
        }
    }
}