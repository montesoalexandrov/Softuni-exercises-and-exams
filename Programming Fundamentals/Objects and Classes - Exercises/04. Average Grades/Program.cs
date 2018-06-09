using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Average_Grades
{
    class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }
        public double AverageGrade => this.Grades.Average();
    }

    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            int numOfStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfStudents; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[0];
                var grades = input.Skip(1).Select(double.Parse).ToArray();
                var student = new Student()
                {
                    Name = name,
                    Grades = grades
                };
                students.Add(student);
            }
            students = students.Where(a => a.AverageGrade >= 5.00).OrderBy(a => a.Name).ThenByDescending(a => a.AverageGrade).ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }
    }
}