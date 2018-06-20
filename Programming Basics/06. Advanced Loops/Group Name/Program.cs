using System;

namespace Group_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine().ToUpper());
            char second = char.Parse(Console.ReadLine().ToLower());
            char third = char.Parse(Console.ReadLine().ToLower());
            char fourth = char.Parse(Console.ReadLine().ToLower());
            int number = int.Parse(Console.ReadLine());

            int counter = 0;

            for (char f = 'A'; f <= first; f++)
            {
                for (char s = 'a'; s <= second; s++)
                {
                    for (char t = 'a'; t <= third; t++)
                    {
                        for (char ff = 'a'; ff <= fourth; ff++)
                        {
                            for (int n = 0; n <= number; n++)
                            {
                                if (f == first && s == second && t == third && ff == fourth && n == number)
                                    break;
                                counter++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
