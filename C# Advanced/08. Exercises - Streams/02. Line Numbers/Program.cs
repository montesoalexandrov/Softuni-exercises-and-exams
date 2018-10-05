using System;
using System.Collections.Generic;
using System.IO;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var readStream = new StreamReader("../../../../files/text.txt"))
            {
                string line;
                var queue = new Queue<string>();

                while ((line = readStream.ReadLine()) != null)
                {
                    queue.Enqueue(line);
                }
                using (var writeStream = new StreamWriter("../../../../files/output.txt"))
                {
                    int counter = 1;

                    foreach (var q in queue)
                    {
                        writeStream.WriteLine($"Line{counter}: {q}");
                        counter++;
                    }
                }
            }
        }
    }
}