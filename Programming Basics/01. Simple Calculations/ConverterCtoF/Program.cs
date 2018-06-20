using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterCtoF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("°C");
            var c = double.Parse(Console.ReadLine());
            var f = c * 1.800 + 32.00;
            Console.WriteLine("°F " + f);
        }
    }
}
