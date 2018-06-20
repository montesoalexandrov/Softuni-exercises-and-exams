using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidht = int.Parse(Console.ReadLine());
            int cakeHeight = int.Parse(Console.ReadLine());

            int cake = cakeWidht * cakeHeight;

            for (int i = 0; i <= cake; i++)
            {
                string pieces = Console.ReadLine();
            
                if (pieces == "STOP")
                {
                    Console.WriteLine($"{cake} pieces are left.");
                    break;
                }
                int currentPieces = int.Parse(pieces);

                cake -= currentPieces;

                if (cake == 0)
                {
                    currentPieces = int.Parse(Console.ReadLine());
                    cake -= currentPieces;
                }
            }
            
            if (cake < 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cake)} pieces more.");
            }
        }
    }   
}
