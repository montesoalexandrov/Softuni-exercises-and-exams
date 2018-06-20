﻿using System;
using System.Text.RegularExpressions;

namespace _04.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\b(?<day>\d{2})(?<separator>.|-|\/)(?<month>[A-Z]{1}[a-z]{2})\2(?<year>\d{4})\b";

            var datesStr = Console.ReadLine();

            var dates = Regex.Matches(datesStr, pattern);

            foreach (Match date in dates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}