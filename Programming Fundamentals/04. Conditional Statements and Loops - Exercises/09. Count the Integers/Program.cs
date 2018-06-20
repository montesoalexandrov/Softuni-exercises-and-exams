using System;

namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            for (int i = 0; i <= 100; i++)
            {
                try
                {
                    var n = int.Parse(Console.ReadLine());
                    counter++;
                }
                catch
                {
                    Console.WriteLine(counter);
                    break;
                }
            }
        }
    }
}
