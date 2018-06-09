using System;

namespace Mobile_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            var srokNaDogovor = Console.ReadLine().ToLower();
            var tipNaDogovor = Console.ReadLine().ToLower();
            var dobavenInternet = Console.ReadLine().ToLower();
            var meseciZaPlashtane = double.Parse(Console.ReadLine());

            if (srokNaDogovor == "one")
            {
                if (tipNaDogovor == "small")
                {
                    if (dobavenInternet == "yes")
                    {
                        Console.WriteLine($"{(9.98 + 5.50) * meseciZaPlashtane:f2} lv.");
                    }
                    else if (dobavenInternet == "no")
                    {
                        Console.WriteLine($"{9.98 * meseciZaPlashtane:f2} lv.");
                    }
                }

                if (tipNaDogovor == "middle")
                {
                    if (dobavenInternet == "yes")
                    {
                        Console.WriteLine($"{(18.99 + 4.35) * meseciZaPlashtane:f2} lv.");
                    }
                    else if (dobavenInternet == "no")
                    {
                        Console.WriteLine($"{18.99 * meseciZaPlashtane:f2} lv.");
                    }
                }

                if (tipNaDogovor == "large")
                {
                    if (dobavenInternet == "yes")
                    {
                        Console.WriteLine($"{(25.98 + 4.35) * meseciZaPlashtane:f2} lv.");
                    }
                    else if (dobavenInternet == "no")
                    {
                        Console.WriteLine($"{25.98 * meseciZaPlashtane:f2} lv.");
                    }
                }

                if (tipNaDogovor == "extralarge")
                {
                    if (dobavenInternet == "yes")
                    {
                        Console.WriteLine($"{(35.99 + 3.85) * meseciZaPlashtane:f2} lv.");
                    }
                    else if (dobavenInternet == "no")
                    {
                        Console.WriteLine($"{35.99 * meseciZaPlashtane:f2} lv.");
                    }
                }
            }

            if (srokNaDogovor == "two")
            {
                if (tipNaDogovor == "small")
                {
                    if (dobavenInternet == "yes")
                    {
                        Console.WriteLine($"{((8.58 + 5.50) * meseciZaPlashtane) - (((8.58 + 5.50) * meseciZaPlashtane) * 0.0375):f2} lv.");
                    }
                    else if (dobavenInternet == "no")
                    {
                        Console.WriteLine($"{(8.58 * meseciZaPlashtane) - ((8.58 * meseciZaPlashtane) * 0.0375):f2} lv.");
                    }
                }

                if (tipNaDogovor == "middle")
                {
                    if (dobavenInternet == "yes")
                    {
                        Console.WriteLine($"{(((17.09 + 4.35) * meseciZaPlashtane)) - (((17.09 + 4.35) * meseciZaPlashtane) * 0.0375):f2} lv.");
                    }
                    else if (dobavenInternet == "no")
                    {
                        Console.WriteLine($"{(17.09 * meseciZaPlashtane) - ((17.09 * meseciZaPlashtane) * 0.0375):f2} lv.");
                    }
                }

                if (tipNaDogovor == "large")
                {
                    if (dobavenInternet == "yes")
                    {
                        Console.WriteLine($"{(((23.59 + 4.35) * meseciZaPlashtane) - ((23.59 + 4.35) * meseciZaPlashtane) * 0.0375):f2} lv.");
                    }
                    else if (dobavenInternet == "no")
                    {
                        Console.WriteLine($"{(23.59 * meseciZaPlashtane) - ((23.59 * meseciZaPlashtane) * 0.0375):f2} lv.");
                    }
                }

                if (tipNaDogovor == "extralarge")
                {
                    if (dobavenInternet == "yes")
                    {
                        Console.WriteLine($"{(((31.79 + 3.85) * meseciZaPlashtane) - ((31.79 + 3.85) * meseciZaPlashtane) * 0.0375):f2} lv.");
                    }
                    else if (dobavenInternet == "no")
                    {
                        Console.WriteLine($"{(31.79 * meseciZaPlashtane) - ((31.79 * meseciZaPlashtane) * 0.0375):f2} lv.");
                    }
                }
            }
        }
    }
}