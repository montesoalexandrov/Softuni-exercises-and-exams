using System;
namespace _03.English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = decimal.Parse(Console.ReadLine());
            var lastDigit = 0;
            var digit = " ";
            Console.WriteLine(PrintLastDigit(num, lastDigit, digit));
        }
        static string PrintLastDigit(decimal num, decimal lastDigit, string digit)
        {
            lastDigit = num % 10;
            switch (Math.Abs(lastDigit))
            {
                case 1: digit = "one"; break;
                case 2: digit = "two"; break;
                case 3: digit = "three"; break;
                case 4: digit = "four"; break;
                case 5: digit = "five"; break;
                case 6: digit = "six"; break;
                case 7: digit = "seven"; break;
                case 8: digit = "eight"; break;
                case 9: digit = "nine"; break;
                case 0: digit = "zero"; break;
            }
            return digit;
        }
    }
}