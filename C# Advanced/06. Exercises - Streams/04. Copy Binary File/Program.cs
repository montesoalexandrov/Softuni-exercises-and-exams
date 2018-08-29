﻿using System;
using System.IO;

namespace _04._Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var sourceFile = new FileStream("..//..//..//copyMe.png", FileMode.Open))
            {
                using (var destinationFile = new FileStream("..//..//..//copyMe-copy.png", FileMode.Create))
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
