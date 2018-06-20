using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rad_deg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Radian:");
            var rad = double.Parse(Console.ReadLine());
            var deg = Math.Round((rad * 180 / Math.PI),0);
            Console.WriteLine("Degrees: " + deg);
        }
    }
}
