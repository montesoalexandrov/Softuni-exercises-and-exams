using System;
using System.Linq;
using System.Text;

namespace _06._Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = Console.ReadLine();
            var num2 = Console.ReadLine();

            if (num1.Length < num2.Length)
            {
                num1 = num1.PadLeft(num2.Length, '0');
            }
            else if (num2.Length < num1.Length)
            {
                num2 = num2.PadLeft(num1.Length, '0');
            }

            int sum = 0;
            var reminder = 0;
            int num = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                sum = (num1[i] - 48) + (num2[i] - 48) + reminder;
                num = sum % 10;
                if (sum > 9)
                {
                    reminder = 1;
                }
                else
                {
                    reminder = 0;
                }
                sb.Append(num);
            }
            if (reminder == 1)
            {
                sb.Append(reminder);
            }
            Console.WriteLine(sb.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray());
        }
    }
}