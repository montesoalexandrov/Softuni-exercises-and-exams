using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            double tegloPratka = double.Parse(Console.ReadLine());
            string tipUsluga = Console.ReadLine().ToLower();
            int razstoqnie = int.Parse(Console.ReadLine());

            double cena = 0;
            double ekspresna = 0;
            double total = 0;

            if (tegloPratka < 1)
            {
                if (tipUsluga == "standard")
                {
                    cena += 0.03 * razstoqnie;
                    total = cena;
                }

                else if (tipUsluga == "express")
                {
                    cena = 0.80 * 0.03;
                    ekspresna = razstoqnie * (tegloPratka * cena);
                    total = ekspresna + (0.03 * razstoqnie);
                }
            }

            else if (tegloPratka >= 1 && tegloPratka <= 10)
            {
                if (tipUsluga == "standard")
                {
                    cena += 0.05 * razstoqnie;
                    total = cena;
                }

                else if (tipUsluga == "express")
                {
                    cena = 0.40 * 0.05;
                    ekspresna = razstoqnie * (tegloPratka * cena);
                    total = ekspresna + (0.05 * razstoqnie);
                }
            }
            else if (tegloPratka >= 11 && tegloPratka <= 40)
            {
                if (tipUsluga == "standard")
                {
                    cena += 0.10 * razstoqnie;
                    total = cena;
                }

                else if (tipUsluga == "express")
                {
                    cena = 0.05 * 0.10;
                    ekspresna = razstoqnie * (tegloPratka * cena);
                    total = ekspresna + (0.10 * razstoqnie);
                }
            }

            else if (tegloPratka >= 41 && tegloPratka <= 90)
            {
                if (tipUsluga == "standard")
                {
                    cena += 0.15 * razstoqnie;
                    total = cena;
                }

                else if (tipUsluga == "express")
                {
                    cena = 0.02 * 0.15;
                    ekspresna = razstoqnie * (tegloPratka * cena);
                    total = ekspresna + (0.15 * razstoqnie);
                }
            }

            else if (tegloPratka >= 91 && tegloPratka <= 150)
            {
                if (tipUsluga == "standard")
                {
                    cena += 0.20 * razstoqnie;
                    total = cena;
                }

                else if (tipUsluga == "express")
                {
                    cena = 0.01 * 0.20;
                    ekspresna = razstoqnie * (tegloPratka * cena);
                    total = ekspresna + (0.20 * razstoqnie);
                }
            }
            Console.WriteLine($"The delivery of your shipment with weight of {tegloPratka:f3} kg. would cost {total:f2} lv.");
        }
    }
}
