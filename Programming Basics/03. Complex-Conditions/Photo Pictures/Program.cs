using System;

namespace Photo_Pictures
{
    class Program
    {
        static void Main(string[] args)
        {
            var broiSnimki = double.Parse(Console.ReadLine());
            var vidSnimki = Console.ReadLine().ToLower();
            var nachinNaPorachvane = Console.ReadLine().ToLower();

            if (nachinNaPorachvane == "online")
            {
                if (vidSnimki == "9x13")
                {
                    var snimki = broiSnimki * 0.16;
                    var namalenie = snimki - (snimki * 0.95);

                    if (broiSnimki >= 50)
                    {
                        var result = (snimki * 0.95) * 0.98;
                        Console.WriteLine($"{result:f2}BGN");
                    }
                    else if (broiSnimki < 50)
                    {
                        var namalenieOnline = $"{ snimki * 0.98:f2}";
                        Console.WriteLine(namalenieOnline + "BGN");
                    }
                }

                if (vidSnimki == "10x15")
                {
                    var snimki = broiSnimki * 0.16;
                    var namalenie = snimki - (snimki * 0.97);

                    if (broiSnimki >= 80)
                    {
                        var result = (snimki * 0.97) * 0.98;
                        Console.WriteLine($"{result:f2}BGN");
                    }
                    else if (broiSnimki < 80)
                    {
                        var namalenieOnline = $"{ snimki * 0.98:f2}";
                        Console.WriteLine(namalenieOnline + "BGN");
                    }
                }

                if (vidSnimki == "13x18")
                {
                    var snimki = broiSnimki * 0.38;
                    var namalenie = snimki - (snimki * 0.97);

                    if (broiSnimki >= 50 && broiSnimki <= 100)
                    {
                        var result = (snimki * 0.97) * 0.98;
                        Console.WriteLine($"{result:f2}BGN");
                    }
                    else if (broiSnimki > 100)
                    {
                        var result = (snimki * 0.95) * 0.98;
                        Console.WriteLine($"{result:f2}BGN");
                    }
                    else if (broiSnimki < 50)
                    {
                        var namalenieOnline = $"{ snimki * 0.98:f2}";
                        Console.WriteLine(namalenieOnline + "BGN");
                    }
                }

                if (vidSnimki == "20x30")
                {
                    var snimki = broiSnimki * 2.90;
                    var namalenie = snimki - (snimki * 0.93);

                    if (broiSnimki >= 10 && broiSnimki <= 50)
                    {
                        var result = (snimki * 0.93) * 0.98;
                        Console.WriteLine($"{result:f2}BGN");
                    }
                    else if (broiSnimki > 50)
                    {
                        var result = (snimki * 0.91) * 0.98;
                        Console.WriteLine($"{result:f2}BGN");
                    }
                    else if (broiSnimki < 50)
                    {
                        var namalenieOnline = $"{ snimki * 0.98:f2}";
                        Console.WriteLine(namalenieOnline + "BGN");
                    }
                }
            }

            else if (nachinNaPorachvane == "office")
            {
                if (vidSnimki == "9x13")
                {
                    var snimki = broiSnimki * 0.16;
                    var namalenie = snimki - (snimki * 0.95);

                    if (broiSnimki >= 50)
                    {
                        Console.WriteLine($"{snimki - namalenie:f2}BGN");
                    }
                    else if (broiSnimki < 50)
                    {
                        Console.WriteLine($"{snimki:f2}BGN");
                    }
                }

                if (vidSnimki == "10x15")
                {
                    var snimki = broiSnimki * 0.16;
                    var namalenie = snimki - (snimki * 0.97);

                    if (broiSnimki >= 80)
                    {
                        Console.WriteLine($"{snimki - namalenie:f2}BGN");
                    }
                    else if (broiSnimki < 80)
                    {
                        Console.WriteLine($"{snimki:f2}BGN");
                    }
                }

                if (vidSnimki == "13x18")
                {
                    var snimki = broiSnimki * 0.38;
                    var namalenie = snimki - (snimki * 0.97);
                    var namalenieNad100 = snimki - (snimki * 0.95);

                    if (broiSnimki >= 50 && broiSnimki <= 100)
                    {
                        Console.WriteLine($"{snimki - namalenie:f2}BGN");
                    }
                    else if (broiSnimki > 100)
                    {
                        Console.WriteLine($"{snimki - namalenieNad100:f2}BGN");
                    }
                    else if (broiSnimki < 50)
                    {
                        Console.WriteLine($"{snimki:f2}BGN");
                    }
                }

                if (vidSnimki == "20x30")
                {
                    var snimki = broiSnimki * 2.90;
                    var namalenie = snimki - (snimki * 0.93);
                    var namalenieNad50 = snimki - (snimki * 0.91);

                    if (broiSnimki >= 10 && broiSnimki <= 50)
                    {
                        Console.WriteLine($"{snimki - namalenie:f2}BGN");
                    }
                    else if (broiSnimki > 50)
                    {
                        Console.WriteLine($"{snimki - namalenieNad50:f2}BGN");
                    }
                    else if (broiSnimki < 10)
                    {
                        Console.WriteLine($"{snimki:f2}BGN");
                    }
                }
            }
        }
    }
}
