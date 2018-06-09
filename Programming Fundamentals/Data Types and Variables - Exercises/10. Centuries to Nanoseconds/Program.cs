using System;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte centuries = sbyte.Parse(Console.ReadLine());
            short years = (short)(centuries * 100);
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            long minutes = (long)(hours * 60);
            long seconds = minutes * 60;
            long milliseconds = (seconds * 1000);
            decimal microseconds = (decimal)milliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds =" +
                $" {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}