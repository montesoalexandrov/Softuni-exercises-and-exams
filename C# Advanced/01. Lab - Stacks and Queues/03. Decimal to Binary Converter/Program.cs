using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputDecimal = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            if (inputDecimal == 0)
            {
                Console.WriteLine(0);
                return;
            }

            while (inputDecimal > 0)
            {
                stack.Push(inputDecimal % 2);
                inputDecimal /= 2;
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}