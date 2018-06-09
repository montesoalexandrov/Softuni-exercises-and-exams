using System;

namespace birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var p = double.Parse(Console.ReadLine());

            var volume = d * w * h;
            var litri = volume * 0.001;
            var procent = p * 0.01;
            var litriall = litri * (1 - procent);

            Console.WriteLine($"{litriall:f3}");
        }
    }
}