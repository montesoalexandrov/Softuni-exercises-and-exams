using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moneyconverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сума:");
            decimal amount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Входна валута:");
            string currencyOne = Console.ReadLine();
            Console.WriteLine("Изходна валута:");
            string currencyTwo = Console.ReadLine();
            decimal convertionOne = new decimal();
            decimal convertionTwo = new decimal();
            decimal BGN = 1;
            decimal USD = 1.79549m;
            decimal EUR = 1.95583m;
            decimal GBP = 2.53405m;
            switch (currencyOne)
            {
                case "BGN":
                    convertionOne = amount * BGN;
                    break;
                case "USD":
                    convertionOne = amount * USD;
                    break;
                case "EUR":
                    convertionOne = amount * EUR;
                    break;
                case "GBP":
                    convertionOne = amount * GBP;
                    break;
            }
            switch (currencyTwo)
            {
                case "BGN":
                    convertionTwo = convertionOne / BGN;
                    break;
                case "USD":
                    convertionTwo = convertionOne / USD;
                    break;
                case "EUR":
                    convertionTwo = convertionOne / EUR;
                    break;
                case "GBP":
                    convertionTwo = convertionOne / GBP;
                    break;
            }
            Console.WriteLine(Math.Round(convertionTwo, 2));
        }
    }
}
