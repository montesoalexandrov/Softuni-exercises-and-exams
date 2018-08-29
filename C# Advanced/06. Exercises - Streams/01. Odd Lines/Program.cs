using System;
using System.IO;

namespace _01._Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var readStream = new StreamReader("..\\..\\Resources\text.txt"))
            {
                string line;
                int counter = 0;

                while ((line = readStream.ReadLine()) != null)
                {
                    if (counter % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    counter++;
                }
            }
        }
    }
}