using System;
class PriceChangeAlert
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine(GetMax(a, b, c));
    }
    private static int GetMax(int a, int b, int c)
    {
        int max = int.MinValue;

        if (a >= b && a >= c)
        {
            max = a;
        }
        else if (b >= a && b >= c)
        {
            max = b;
        }
        else if (c >= a && c >= b)
        {
            max = c;
        }
        return max;
    }
}