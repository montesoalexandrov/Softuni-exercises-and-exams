using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine().ToLower();
            var second = Console.ReadLine().ToLower(); 

            if (first == second)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");

        }
    }
}
