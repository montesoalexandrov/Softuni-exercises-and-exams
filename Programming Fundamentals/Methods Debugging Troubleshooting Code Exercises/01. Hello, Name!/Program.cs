﻿using System;
namespace _01.Hello__Name_
{
    class Program
    {
        static void PrintName(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }

        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintName(name);
        }
    }
}
