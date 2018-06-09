using System;

namespace P11
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMin = 0;
            double oddMax = 0;

            double evenSum = 0;
            double evenMin = 0;
            double evenMax = 0;

            for (int i = 1; i < n + 1; i++)
            {
                double currentNum = double.Parse(Console.ReadLine());


                if (i % 2 != 0)
                {
                    if (i == 1)
                    {
                        oddMin = currentNum;
                        oddMax = currentNum;
                    }

                    if (oddMin > currentNum)
                    {
                        oddMin = currentNum;
                    }

                    else if (oddMax < currentNum)
                    {
                        oddMax = currentNum;
                    }


                    oddSum += currentNum;
                }

                else if (i % 2 == 0)
                {
                    if (i == 2)
                    {
                        evenMin = currentNum;
                        evenMax = currentNum;
                    }

                    if (evenMin > currentNum)
                    {
                        evenMin = currentNum;
                    }

                    else if (evenMax < currentNum)
                    {
                        evenMax = currentNum;
                    }

                    evenSum += currentNum;
                }
            }
            Console.WriteLine($"OddSum={oddSum},");
            if (oddMin != 0 && oddMax != 0)
            {
                Console.WriteLine($"OddMin={oddMin},");
                Console.WriteLine($"OddMax={oddMax},");
            }

            if (oddMin == 0 && oddMax == 0)
            {
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
            }

            Console.WriteLine($"EvenSum={evenSum},");
            if (evenMin != 0 && evenMax != 0)
            {
                Console.WriteLine($"EvenMin={evenMin},");
                Console.WriteLine($"EvenMax={evenMax}");
            }

            if (evenMin == 0 && evenMax == 0)
            {
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
        }
    }
}