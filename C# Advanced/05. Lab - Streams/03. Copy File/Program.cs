using System;
using System.IO;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var sourceFile = new FileStream("..//..//..//stream.png", FileMode.Open))
            {
                using (var destinationFile = new FileStream("..//..//..//stream-copy.png", FileMode.Create))
                {
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        var readBytesCount = sourceFile.Read(buffer, 0, buffer.Length);

                        if (readBytesCount == 0)
                        {
                            break;
                        }

                        destinationFile.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}