using System;
using System.Linq;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOne = Console.ReadLine().Split(' ');
            string[] arrayTwo = Console.ReadLine().Split(' ');
            int minLength = Math.Min(arrayOne.Length, arrayTwo.Length);
            int leftSeqLen = 0;
            for (int i = 0; i < minLength; i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    break;
                }
                leftSeqLen++;
            }
            arrayOne = arrayOne.Reverse().ToArray();
            arrayTwo = arrayTwo.Reverse().ToArray();
            int rightSeqLen = 0;

            for (int j = 0; j < minLength; j++)
            {
                if (arrayOne[j] != arrayTwo[j])
                {
                    break;
                }
                rightSeqLen++;
            }
            Console.WriteLine(Math.Max(leftSeqLen, rightSeqLen));
        }
    }
}