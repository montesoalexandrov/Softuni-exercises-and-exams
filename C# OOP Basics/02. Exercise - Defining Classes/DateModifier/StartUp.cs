﻿using System;

namespace DateModifier
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine();
            var second = Console.ReadLine();
            var result = new DateModifier(first, second);
            result.DaysDifference(result);
        }
    }
}
