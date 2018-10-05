using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Dictionary<string, List<double>>();

            int numberOfStudents = int.Parse(Console.ReadLine());

            for (int counter = 0; counter < numberOfStudents; counter++)
            {
                var student = Console.ReadLine().Split();
                var name = student[0];
                double grade = double.Parse(student[1]);

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());
                }
                students[name].Add(grade);
            }

            students.OrderByDescending(g => g.Value.Average());

            foreach (var student in students)
            {
                Console.Write($"{student.Key} -> ");
                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
        }
    }
}