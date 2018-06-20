using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000DAYSonEARTH
{
    class Program
    {
        static void Main(string[] args)
        {
            var birthDate = Console.ReadLine();
            var format = "dd-MM-yyyy";
            var thousandDay = DateTime.ParseExact(birthDate, format, CultureInfo.InvariantCulture);
            thousandDay = thousandDay.AddDays(999);
            Console.WriteLine(thousandDay.ToString(format));
        }
    }
}