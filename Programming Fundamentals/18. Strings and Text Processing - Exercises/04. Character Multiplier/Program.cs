using System;
using System.Linq;

namespace _04._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(' ').ToArray();
            var word = text[0];
            var word2 = text[1];


            MultiplyChars(word, word2);

            Console.WriteLine(MultiplyChars(word, word2));
        }

        static int MultiplyChars(string word, string word2)
        {
            var sum = 0;
            for (int i = 0; i < Math.Min(word.Length, word2.Length); i++)
            {
                sum += word[i] * word2[i];
            }

            for (int i = Math.Min(word.Length, word2.Length); i < Math.Max(word.Length, word2.Length); i++)
            {
                try
                {
                    sum += word[i];
                }
                catch
                {
                    sum += word2[i];
                }
            }
            return sum;
        }
    }
}
