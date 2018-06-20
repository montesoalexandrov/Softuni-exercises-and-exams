using System;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n + 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                    new string(' ', n - i),
                    new string('*', i),
                    " | ");

                //                Console.Write(new string(' ', n - i));
                //               Console.Write(new string('*', i));
                //               Console.Write(' ');
                //               Console.Write('|');
                //                Console.Write(' ');
                //               Console.Write(new string('*', i));
                //                Console.Write(new string(' ', n));
                //              Console.WriteLine();
            }
        }
    }
}
