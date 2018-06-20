using System;

namespace Плодови_коктейли
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToLower();
            var size = Console.ReadLine().ToLower();
            var number = Double.Parse(Console.ReadLine());

            if (size == "small")
            {
                var watermelon = number * (56 * 2);
                var mango = number * (36.66 * 2);
                var pineapple = number * (42.10 * 2);
                var raspberry = number * (20 * 2);

                if (fruit == "watermelon")
                {
                    if (watermelon >= 400 && watermelon <= 1000)
                    {
                        Console.WriteLine($"{watermelon - (watermelon * 0.15):f2} lv.");
                    }
                    else if (watermelon > 400 && watermelon > 1000)
                    {
                        Console.WriteLine($"{watermelon - (watermelon * 0.50):f2} lv.");
                    }
                    else if (watermelon < 400)
                    {
                        Console.WriteLine($"{watermelon:f2} lv.");
                    }
                }

                if (fruit == "mango")
                { 
                    if (mango >= 400 && mango <= 1000)
                    {
                        Console.WriteLine($"{mango - (mango * 0.15):f2} lv.");
                    }
                    else if (mango > 400 && mango > 1000)
                    {
                        Console.WriteLine($"{mango - (mango * 0.50):f2} lv.");
                    }
                    else if (mango < 400)
                    {
                        Console.WriteLine($"{mango:f2} lv.");
                    }
                }

                if (fruit == "pineapple")
                {
                    if (pineapple >= 400 && pineapple <= 1000)
                    {
                        Console.WriteLine($"{pineapple - (pineapple * 0.15):f2} lv.");
                    }
                    else if (pineapple > 400 && pineapple > 1000)
                    {
                        Console.WriteLine($"{pineapple - (pineapple * 0.50):f2} lv.");
                    }
                    else if (pineapple < 400)
                    {
                        Console.WriteLine($"{pineapple:f2} lv.");
                    }
                }

                if (fruit == "raspberry")
                {
                    if (raspberry >= 400 && raspberry <= 1000)
                    {
                        Console.WriteLine($"{raspberry - (raspberry * 0.15):f2} lv.");
                    }
                    else if (raspberry > 400 && raspberry > 1000)
                    {
                        Console.WriteLine($"{raspberry - (raspberry * 0.50):f2} lv.");
                    }
                    else if (raspberry < 400)
                    {
                        Console.WriteLine($"{raspberry:f2} lv.");
                    }
                }
            }

            if (size == "big")
            {
                var watermelon = number * (28.70 * 5);
                var mango = number * (19.60 * 5);
                var pineapple = number * (24.80 * 5);
                var raspberry = number * (15.20 * 5);

                if (fruit == "watermelon")
                {
                    if (watermelon >= 400 && watermelon <= 1000)
                    {
                        Console.WriteLine($"{watermelon - (watermelon * 0.15):f2} lv.");
                    }
                    else if (watermelon > 400 && watermelon > 1000)
                    {
                        Console.WriteLine($"{watermelon - (watermelon * 0.50):f2} lv.");
                    }
                    else if (watermelon < 400)
                    {
                        Console.WriteLine($"{watermelon:f2} lv.");
                    }
                }

                if (fruit == "mango")
                {
                    if (mango >= 400 && mango <= 1000)
                    {
                        Console.WriteLine($"{mango - (mango * 0.15):f2} lv.");
                    }
                    else if (mango > 400 && mango > 1000)
                    {
                        Console.WriteLine($"{mango - (mango * 0.50):f2} lv.");
                    }
                    else if (mango < 400)
                    {
                        Console.WriteLine($"{mango:f2} lv.");
                    }
                }

                if (fruit == "pineapple")
                {
                    if (pineapple >= 400 && pineapple <= 1000)
                    {
                        Console.WriteLine($"{pineapple - (pineapple * 0.15):f2} lv.");
                    }
                    else if (pineapple > 400 && pineapple > 1000)
                    {
                        Console.WriteLine($"{pineapple - (pineapple * 0.50):f2} lv.");
                    }
                    else if (pineapple < 400)
                    {
                        Console.WriteLine($"{pineapple:f2} lv.");
                    }
                }

                if (fruit == "raspberry")
                {
                    if (raspberry >= 400 && raspberry <= 1000)
                    {
                        Console.WriteLine($"{raspberry - (raspberry * 0.15):f2} lv.");
                    }
                    else if (raspberry > 400 && raspberry > 1000)
                    {
                        Console.WriteLine($"{raspberry - (raspberry * 0.50):f2} lv.");
                    }
                    else if (raspberry < 400)
                    {
                        Console.WriteLine($"{raspberry:f2} lv.");
                    }
                }
            }
        }
    }
}
