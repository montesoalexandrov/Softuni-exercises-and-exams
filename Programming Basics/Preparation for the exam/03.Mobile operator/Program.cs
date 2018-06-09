using System;

namespace _03.Mobile_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string srokNaDogovor = Console.ReadLine().ToLower();
            string tipNaDogovor = Console.ReadLine().ToLower();
            string dobavenInternet = Console.ReadLine().ToLower();
            int broiMeseci = int.Parse(Console.ReadLine());

            double price = 0;

            if (srokNaDogovor == "one")
            {
                if (tipNaDogovor == "small")
                {
                    price = 9.98;
                }

                else if (tipNaDogovor == "middle")
                {
                    price = 18.99;
                }

                else if (tipNaDogovor == "large")
                {
                    price = 25.98;
                }

                else if (tipNaDogovor == "extralarge")
                {
                    price = 35.99;
                }
            }

            else if (srokNaDogovor == "two")
            {
                if (tipNaDogovor == "small")
                {
                    price = 8.58;
                }

                else if (tipNaDogovor == "middle")
                {
                    price = 17.09;
                }

                else if (tipNaDogovor == "large")
                {
                    price = 23.59;
                }

                else if (tipNaDogovor == "extralarge")
                {
                    price = 31.79;
                }
            }

            if (dobavenInternet == "yes")
            {
                if (price <= 10.00)
                {
                    price += 5.50;
                }

                else if (price <= 30.00)
                {
                    price += 4.35;
                }

                else if (price > 30.00)
                {
                    price += 3.85;
                }
            }

            double sum = price * broiMeseci;

            if (srokNaDogovor == "two")
            {
                Console.WriteLine($"{sum - (sum * 0.0375):f2} lv.");
            }

            else
            {
                Console.WriteLine($"{sum:f2} lv.");
            }
        }
    }
}
