using System;

namespace School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            var sezon = Console.ReadLine().ToLower();
            var vidGrupa = Console.ReadLine().ToLower();
            var broiUchenici = double.Parse(Console.ReadLine());
            var broinoshtuvki = double.Parse(Console.ReadLine());

            if (vidGrupa == "girls" || vidGrupa == "boys")
            {
                if (sezon == "winter")
                {
                    var cena = broinoshtuvki * broiUchenici * 9.60;

                    if (broiUchenici >= 50)
                    {
                        var otstapka = cena - (cena * 0.50);

                        if (vidGrupa == "girls")
                        {
                            Console.WriteLine($"Gymnastics {otstapka:f2} lv.");
                        }

                        else if (vidGrupa == "boys")
                        {
                            Console.WriteLine($"Judo {otstapka:f2} lv.");
                        }
                    }

                    else if (broiUchenici >= 20 && broiUchenici < 50)
                    {
                        var otstapka = cena - (cena * 0.15);

                        if (vidGrupa == "girls")
                        {
                            Console.WriteLine($"Gymnastics {otstapka:f2} lv.");
                        }

                        else if (vidGrupa == "boys")
                        {
                            Console.WriteLine($"Judo {otstapka:f2} lv.");
                        }
                    }

                    else if (broiUchenici >= 10 && broiUchenici < 20)
                    {
                        var otstapka = cena - (cena * 0.05);

                        if (vidGrupa == "girls")
                        {
                            Console.WriteLine($"Gymnastics {otstapka:f2} lv.");
                        }

                        else if (vidGrupa == "boys")
                        {
                            Console.WriteLine($"Judo {otstapka:f2} lv.");
                        }
                    }

                    else if (broiUchenici < 10)
                    {
                        if (vidGrupa == "girls")
                        {
                            Console.WriteLine($"Gymnastics {cena:f2} lv.");
                        }

                        else if (vidGrupa == "boys")
                        {
                            Console.WriteLine($"Judo {cena:f2} lv.");
                        }
                    }
                }

                else if (sezon == "spring")
                {
                    var cena = broinoshtuvki * broiUchenici * 7.20;

                    if (broiUchenici >= 50)
                    {
                        var otstapka = cena - (cena * 0.50);

                        if (vidGrupa == "girls")
                        {
                            Console.WriteLine($"Athletics {otstapka:f2} lv.");
                        }

                        else if (vidGrupa == "boys")
                        {
                            Console.WriteLine($"Tennis {otstapka:f2} lv.");
                        }
                    }

                    else if (broiUchenici >= 20 && broiUchenici < 50)
                    {
                        var otstapka = cena - (cena * 0.15);

                        if (vidGrupa == "girls")
                        {
                            Console.WriteLine($"Athletics {otstapka:f2} lv.");
                        }

                        else if (vidGrupa == "boys")
                        {
                            Console.WriteLine($"Tennis {otstapka:f2} lv.");
                        }
                    }

                    else if (broiUchenici >= 10 && broiUchenici < 20)
                    {
                        var otstapka = cena - (cena * 0.05);

                        if (vidGrupa == "girls")
                        {
                            Console.WriteLine($"Athletics {otstapka:f2} lv.");
                        }

                        else if (vidGrupa == "boys")
                        {
                            Console.WriteLine($"Tennis {otstapka:f2} lv.");
                        }
                    }

                    else if (broiUchenici < 10)
                    {
                        if (vidGrupa == "girls")
                        {
                            Console.WriteLine($"Athletics {cena:f2} lv.");
                        }

                        else if (vidGrupa == "boys")
                        {
                            Console.WriteLine($"Tennis {cena:f2} lv.");
                        }
                    }
                }

                else if (sezon == "summer")
                {
                    var cena = broinoshtuvki * broiUchenici * 15;

                    if (broiUchenici >= 50)
                    {
                        var otstapka = cena - (cena * 0.50);

                        if (vidGrupa == "girls")
                        {
                            Console.WriteLine($"Volleyball {otstapka:f2} lv.");
                        }

                        else if (vidGrupa == "boys")
                        {
                            Console.WriteLine($"Football {otstapka:f2} lv.");
                        }
                    }

                    else if (broiUchenici >= 20 && broiUchenici < 50)
                    {
                        var otstapka = cena - (cena * 0.15);

                        if (vidGrupa == "girls")
                        {
                            Console.WriteLine($"Volleyball {otstapka:f2} lv.");
                        }

                        else if (vidGrupa == "boys")
                        {
                            Console.WriteLine($"Football {otstapka:f2} lv.");
                        }
                    }

                    else if (broiUchenici >= 10 && broiUchenici < 20)
                    {
                        var otstapka = cena - (cena * 0.05);

                        if (vidGrupa == "girls")
                        {
                            Console.WriteLine($"Volleyball {otstapka:f2} lv.");
                        }

                        else if (vidGrupa == "boys")
                        {
                            Console.WriteLine($"Football {otstapka:f2} lv.");
                        }
                    }

                    else if (broiUchenici < 10)
                    {
                        if (vidGrupa == "girls")
                        {
                            Console.WriteLine($"Volleyball {cena:f2} lv.");
                        }

                        else if (vidGrupa == "boys")
                        {
                            Console.WriteLine($"Football {cena:f2} lv.");
                        }
                    }
                }
            }

            else if (vidGrupa == "mixed")
            {
                if (sezon == "winter")
                {
                    var cena = broinoshtuvki * broiUchenici * 10;

                    if (broiUchenici >= 50)
                    {
                        var otstapka = cena - (cena * 0.50);
                        Console.WriteLine($"Ski {otstapka:f2} lv.");
                    }

                    else if (broiUchenici >= 20 && broiUchenici < 50)
                    {
                        var otstapka = cena - (cena * 0.15);
                        Console.WriteLine($"Ski {otstapka:f2} lv.");
                    }

                    else if (broiUchenici >= 10 && broiUchenici < 20)
                    {
                        var otstapka = cena - (cena * 0.05);
                        Console.WriteLine($"Ski {otstapka:f2} lv.");
                    }

                    else if (broiUchenici < 10)
                    {
                        Console.WriteLine($"Ski {cena:f2} lv.");
                    }
                }

                else if (sezon == "spring")
                {
                    var cena = broinoshtuvki * broiUchenici * 9.50;

                    if (broiUchenici >= 50)
                    {
                        var otstapka = cena - (cena * 0.50);
                        Console.WriteLine($"Cycling {otstapka:f2} lv.");
                    }

                    else if (broiUchenici >= 20 && broiUchenici < 50)
                    {
                        var otstapka = cena - (cena * 0.15);
                        Console.WriteLine($"Cycling {otstapka:f2} lv.");
                    }

                    else if (broiUchenici >= 10 && broiUchenici < 20)
                    {
                        var otstapka = cena - (cena * 0.05);
                        Console.WriteLine($"Cycling {otstapka:f2} lv.");
                    }

                    else if (broiUchenici < 10)
                    {
                        Console.WriteLine($"Cycling {cena:f2} lv.");
                    }
                }

                else if (sezon == "summer")
                {
                    var cena = broinoshtuvki * broiUchenici * 20;

                    if (broiUchenici >= 50)
                    {
                        var otstapka = cena - (cena * 0.50);
                        Console.WriteLine($"Swimming {otstapka:f2} lv.");
                    }

                    else if (broiUchenici >= 20 && broiUchenici < 50)
                    {
                        var otstapka = cena - (cena * 0.15);
                        Console.WriteLine($"Swimming {otstapka:f2} lv.");
                    }

                    else if (broiUchenici >= 10 && broiUchenici < 20)
                    {
                        var otstapka = cena - (cena * 0.05);
                        Console.WriteLine($"Swimming {otstapka:f2} lv.");
                    }

                    else if (broiUchenici < 10)
                    {
                        Console.WriteLine($"Swimming {cena:f2} lv.");
                    }
                }
            }
        }
    }
}
