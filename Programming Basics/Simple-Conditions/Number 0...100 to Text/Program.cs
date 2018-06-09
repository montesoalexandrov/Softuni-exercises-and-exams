using System;
 
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n < 0 || n > 100) { Console.WriteLine("Invalid Number"); }
        else if (n == 0 || n == 100) { Console.WriteLine("{0}", (n==0)?"zero":"one hundred"); }
        else
        {
            string[] ones = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = { "", "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            int firstDigit = n / 10;
            int secondDigit = n % 10;
            if (firstDigit < 2 || secondDigit == 0) { Console.WriteLine("{0}", (firstDigit<2)?ones[n] : tens[firstDigit]); }
            else { Console.WriteLine($"{tens[firstDigit]} {ones[secondDigit]}"); }
        }
    }
}