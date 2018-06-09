using System;

namespace _02._Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var pattern = Console.ReadLine().ToLower();

            int counter = 0;
            int index = text.IndexOf(pattern);
            while(index != - 1)
            {
                counter++;
                index = text.IndexOf(pattern, index + 1);
            }
            Console.WriteLine(counter);
        }
    }
}
