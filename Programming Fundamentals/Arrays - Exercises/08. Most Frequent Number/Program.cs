using System;
using System.Linq;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] array = Console.ReadLine().Split(' ').Select(ushort.Parse).ToArray();
            ushort[] count = new ushort[65535];
            foreach (ushort num in array)
            {
                count[num]++;
            }
            int maxFrequence = count.Max();

            for (int i = 0; i < array.Length; i++)
            {
                if (count[array[i]] == maxFrequence)
                {
                    Console.WriteLine(array[i]);
                    return;
                }
            }
        }
    }
}