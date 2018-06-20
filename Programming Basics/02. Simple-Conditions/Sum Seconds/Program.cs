using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int seconds = first + second + third;
            int minutes = 0;

            if (seconds > 59)
            {
                minutes++;
                seconds = seconds - 60;
            }
            if (seconds > 59)
            {
                minutes++;
                seconds = seconds - 60;
            }
            if (seconds < 10)
                Console.WriteLine(minutes + ":" + "0" + seconds);
            else
            {
                Console.WriteLine(minutes + ":" + seconds);
            }
        }
    }
}
