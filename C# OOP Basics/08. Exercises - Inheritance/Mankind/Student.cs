namespace Mankind
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Student : Human
    {
        private string facultyNumber;

        public string FacultyNumber
        { 
            get { return facultyNumber; }
            set
            {
                string pattern = @"^[a-zA-Z0-9]+$";
                if (!Regex.IsMatch(value, pattern))
                {
                    throw new ArgumentException($"Invalid faculty number!");
                }

                if (value?.Length < 5 || value?.Length > 10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                facultyNumber = value;
            }
        }

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"First Name: {this.FirstName}");
            sb.AppendLine($"Last Name: {this.LastName}");
            sb.AppendLine($"Faculty number: {this.FacultyNumber}");
            return sb.ToString();
        }
    }
}