﻿using System;

namespace Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());

            if (!(num >= 100 && num <= 200 || num == 0))
                Console.WriteLine("invalid");
        }
    }
}
