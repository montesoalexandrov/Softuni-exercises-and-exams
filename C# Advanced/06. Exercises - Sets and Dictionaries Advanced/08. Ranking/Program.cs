using System;
using System.Collections.Generic;
using System.Linq;

class Ranking
{
    static void Main()
    {
        var contests = new Dictionary<string, string>();
        var students = new SortedDictionary<string, Dictionary<string, int>>();

        var input = string.Empty;

        while ((input = Console.ReadLine()) != "end of contests")
        {
            var tokens = input.Split(':');

            var contestName = tokens[0];
            var password = tokens[1];

            if (!contests.ContainsKey(contestName))
            {
                contests.Add(contestName, password);
            }
        }

        while ((input = Console.ReadLine()) != "end of submissions")
        {
            var tokens = input.Split("=>");

            var contestName = tokens[0];
            var password = tokens[1];
            var username = tokens[2];
            int points = int.Parse(tokens[3]);

            if (contests.ContainsKey(contestName) && contests.ContainsValue(password))
            {
                if (!students.ContainsKey(username))
                {
                    students.Add(username, new Dictionary<string, int>());
                    students[username].Add(contestName, points);
                }

                else
                {
                    if (!students[username].ContainsKey(contestName))
                    {
                        students[username].Add(contestName, points);
                    }
                    else
                    {
                        if (students[username][contestName] < points)
                        {
                            students[username][contestName] = points;
                        }
                    }
                }
            }
        }
        
        var bestStudent = students.OrderByDescending(x => x.Value.Values.Sum()).FirstOrDefault().Key;
        var bestPoints = students[bestStudent].Values.Sum();

        Console.WriteLine($"Best candidate is {bestStudent} with total {bestPoints} points.");
        Console.WriteLine("Ranking:");

        foreach (var student in students)
        {
            Console.WriteLine($"{student.Key}");
            foreach (var course in student.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"#  {course.Key} -> {course.Value}");
            }
        }
    }
}