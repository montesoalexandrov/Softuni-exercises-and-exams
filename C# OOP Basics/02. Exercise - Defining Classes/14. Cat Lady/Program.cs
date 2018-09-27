using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var cats = GetCats();
        PrintCat(cats);
    }

    private static void PrintCat(Stack<Cat> cats)
    {
        var catToPrint = Console.ReadLine();
        var foundCat = cats.FirstOrDefault(c => c.Name == catToPrint);
        Console.WriteLine(foundCat.ToString());
    }

    private static Stack<Cat> GetCats()
    {
        var cats = new Stack<Cat>();
        var input = Console.ReadLine().Split();

        while (input[0] != "End")
        {
            var breed = input[0];
            var name = input[1];
            var characteristicValue = double.Parse(input[2]);
            cats.Push(new Cat(name, breed, characteristicValue));

            input = Console.ReadLine().Split();
        }

        return cats;
    }
}