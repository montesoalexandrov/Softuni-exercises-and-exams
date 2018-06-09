using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern = @"\b[a-zA-Z][\w]{2,24}\b";
            string users = String.Empty;

            foreach (var user in input)
            {
                users = String.Join(" ", input);
            }

            MatchCollection validUsers = Regex.Matches(users, pattern);

            var couples = new Dictionary<Match, Match>();
            int sum = 0;
            int tempSum = 0;

            for (int i = 0; i < validUsers.Count - 1; i++)
            {
                tempSum = validUsers[i].Length + validUsers[i + 1].Length;

                if(tempSum > sum)
                {
                    sum = tempSum;
                    couples.Clear();
                    couples.Add(validUsers[i], validUsers[i + 1]);
                }
            }

            foreach (var user in couples)
            {
                Console.WriteLine(user.Key);
                Console.WriteLine(user.Value);
            }
        }
    }
}