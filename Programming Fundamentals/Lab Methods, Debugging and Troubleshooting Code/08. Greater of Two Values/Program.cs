using System;

namespace _08.Greater_of_Two_Values
{
    class Program
    {
        static int GetMaxInt(int a, int b)
        {
            return Math.Max(a, b);
        }
        static char GetMaxChar(char a, char b)
        {
            return (char)Math.Max(a, b);
        }
        static string GetMaxStr(string a, string b)
        {
            if (a.CompareTo(b) >= 0)
                return a;
            return b;
        }
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int max = GetMaxInt(a, b);
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                char max = GetMaxChar(a, b);
                Console.WriteLine(max);
            }
            else if (type == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                string max = GetMaxStr(a, b);
                Console.WriteLine(max);
            }
        }
    }
}
