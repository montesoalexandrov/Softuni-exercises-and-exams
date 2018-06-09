using System;

namespace _06._Stupid_password_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (char c = 'a'; c < 'a' + l; c++)
                    {
                        for (char d = 'a'; d <  'a' + l; d++)
                        {
                            var max = Math.Max(i, j);

                            for (int p = max + 1; p <= n; p++)
                            {
                                Console.Write($"{i}{j}{c}{d}{p} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
