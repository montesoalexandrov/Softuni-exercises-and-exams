﻿using System;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());
            double comission = 0.0;

            if (town != "sofia" && town != "varna" && town != "plovdiv" || sales < 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                if (town == "sofia")
                {
                    if (sales >= 0 && sales <= 500) comission = 0.05;
                    else if (sales > 500 && sales <= 1000) comission = 0.07;
                    else if (sales > 1000 && sales <= 10000) comission = 0.08;
                    else if (sales > 10000) comission = 0.12;
                }

                if (town == "varna")
                {
                    if (sales >= 0 && sales <= 500) comission = 0.045;
                    else if (sales > 500 && sales <= 1000) comission = 0.075;
                    else if (sales > 1000 && sales <= 10000) comission = 0.10;
                    else if (sales > 10000) comission = 0.13;
                }

                if (town == "plovdiv")
                {
                    if (sales >= 0 && sales <= 500) comission = 0.055;
                    else if (sales > 500 && sales <= 1000) comission = 0.08;
                    else if (sales > 1000 && sales <= 10000) comission = 0.12;
                    else if (sales > 10000) comission = 0.145;
                }
            }
               
            Console.WriteLine("{0:f2}", sales * comission);
        }
    }
}
