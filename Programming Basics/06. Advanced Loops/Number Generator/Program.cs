using System;

namespace Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int special = int.Parse(Console.ReadLine());
            int control = int.Parse(Console.ReadLine());

            bool shouldBreak = false;

            for (int m = M; m > 0; m--)
            {
                for (int n = N; n > 0; n--)
                {
                    for (int l = L; l > 0; l--)
                    {
                        int number = m * 100 + n * 10 + l;
                        if (number % 3 == 0)
                            special += 5;
                        else if (l == 5)
                            special -= 2;
                        else if (number % 2 == 0)
                            special *= 2;

                        if (special >= control)
                        {
                            shouldBreak = true;
                            break; 
                        }
                    }
                    if (shouldBreak)
                        break;
                }
                if (shouldBreak)
                    break;
            }
            if (shouldBreak)
                Console.WriteLine($"Yes! Control number was reached! Current special number is {special}.");
            else
                Console.WriteLine($"No! {special} is the last reached special number.");
        }
    }
}
