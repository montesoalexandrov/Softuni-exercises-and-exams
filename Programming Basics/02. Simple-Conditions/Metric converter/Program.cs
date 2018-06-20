using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metricconverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Разстояние:");
            decimal distance = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Входна мерна единица:");
            string distanceOne = Console.ReadLine();
            Console.WriteLine("Изходна мерна единица:");
            string distanceTwo = Console.ReadLine();
            decimal convertionOne = new decimal();
            decimal convertionTwo = new decimal();
            decimal m = 1;
            decimal mm = 1000;
            decimal cm = 100;
            decimal mi = 0.000621371192m;
            decimal inch = 39.3700787m;
            decimal km = 0.001m;
            decimal ft = 3.2808399m;
            decimal yd = 1.0936133m;
            switch (distanceOne)
            {
                case "m":
                    convertionOne = distance * m;
                    break;
                case "mm":
                    convertionOne = distance * mm;
                    break;
                case "cm":
                    convertionOne = distance * cm;
                    break;
                case "mi":
                    convertionOne = distance * mi;
                    break;
                case "inch":
                    convertionOne = distance * inch;
                    break;
                case "km":
                    convertionOne = distance * km;
                    break;
                case "ft":
                    convertionOne = distance * ft;
                    break;
                case "yd":
                    convertionOne = distance * yd;
                    break;
            }
            switch (distanceTwo)
            {
                case "m":
                    convertionTwo = convertionOne / m;
                    break;
                case "mm":
                    convertionTwo = convertionOne / mm;
                    break;
                case "cm":
                    convertionTwo = convertionOne / cm;
                    break;
                case "mi":
                    convertionTwo = convertionOne / mi;
                    break;
                case "inch":
                    convertionTwo = convertionOne / inch;
                    break;
                case "km":
                    convertionTwo = convertionOne / km;
                    break;
                case "ft":
                    convertionTwo = convertionOne / ft;
                    break;
                case "yd":
                    convertionTwo = convertionOne / yd;
                    break;
            }
            Console.WriteLine(Math.Round(convertionTwo, 8));
        }
    }
}