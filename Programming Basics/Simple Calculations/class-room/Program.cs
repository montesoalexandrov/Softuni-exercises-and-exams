using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_room
{
    class Program
    {
        static void Main(string[] args)
        {
            //areaRoom

            var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var areaH = Math.Round((h / 120),2);
            var areaW = Math.Round(((w - 100) / 70),2);
            var workPLaces = Math.Round((areaH * areaW - 3),2);
            Console.WriteLine("Places:" + workPLaces);
        }
    }
}
