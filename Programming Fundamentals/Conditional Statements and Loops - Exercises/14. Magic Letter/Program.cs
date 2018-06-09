using System;

namespace _14.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLine = char.Parse(Console.ReadLine());
            char secondLine = char.Parse(Console.ReadLine());
            char thirdLine = char.Parse(Console.ReadLine());

            int minLetter = Math.Min(secondLine, thirdLine);
            int maxLetter = Math.Max(secondLine, thirdLine);

            for (char i = firstLine; i <= secondLine; i++)
            {
                for (char j = firstLine; j <= secondLine; j++)
                {
                    for (char k = firstLine; k <= secondLine; k++)
                    {
                        if (i != thirdLine && j != thirdLine && k != thirdLine)
                            Console.Write($"{i}{j}{k} ");
                    }
                }
            }
        }
    }
}
