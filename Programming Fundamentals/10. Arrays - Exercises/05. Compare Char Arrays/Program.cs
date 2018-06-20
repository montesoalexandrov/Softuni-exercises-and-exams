using System;
using System.Linq;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int min = Math.Min(arr1.Length, arr2.Length);
            for (int i = 0; i < min; i++)
            {
                if (arr1[i] < arr2[i])
                {
                    Console.WriteLine(String.Join("", arr1));
                    Console.WriteLine(String.Join("", arr2));
                    break;
                }
                else if (arr2[i] < arr1[i])
                {
                    Console.WriteLine(String.Join("", arr2));
                    Console.WriteLine(String.Join("", arr1));
                    break;
                }
                else
                {
                    if (arr1.Length < arr2.Length)
                    {
                        Console.WriteLine(String.Join("", arr1));
                        Console.WriteLine(String.Join("", arr2));
                        break;
                    }
                    else if (arr2.Length < arr1.Length)
                    {
                        Console.WriteLine(String.Join("", arr2));
                        Console.WriteLine(String.Join("", arr1));
                        break;
                    }
                    else
                    {
                        Console.WriteLine(String.Join("", arr1));
                        Console.WriteLine(String.Join("", arr2));
                        break;
                    }
                }
            }
        }
    }
}