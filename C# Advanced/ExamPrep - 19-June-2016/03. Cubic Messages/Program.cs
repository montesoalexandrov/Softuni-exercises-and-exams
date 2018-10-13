using System;
using System.Text.RegularExpressions;

namespace _03._Cubic_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Over!")
            {
                string message = string.Empty;
                string numbers = string.Empty;
                string verificationCode = string.Empty;
                int lengthOfMessage = 0;

                string pattern = @"^(\d+)([A-Za-z]+)([^A-Za-z]*)$";

                MatchCollection matches = Regex.Matches(input, pattern);

                if (matches.Count > 0)
                {
                    message = matches[0].Groups[2].ToString();
                    numbers = matches[0].Groups[1].ToString() + matches[0].Groups[3].ToString();

                    input = Console.ReadLine();
                    lengthOfMessage = int.Parse(input);

                    if (lengthOfMessage == message.Length)
                    {
                        foreach (char ch in numbers)
                        {
                            int index = -1;

                            if (int.TryParse(ch.ToString(), out index))
                            {
                                if (index >= 0 && index < message.Length)
                                {
                                    verificationCode += message[index];
                                }
                                else
                                {
                                    verificationCode += " ";
                                }
                            }
                        }
                    }
                    if (verificationCode != string.Empty)
                    {
                        Console.WriteLine($"{message} == {verificationCode}");
                    }
                }
            }
        }
    }
}