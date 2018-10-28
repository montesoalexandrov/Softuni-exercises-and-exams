namespace Mankind
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal hoursPerDay;

        public decimal WeekSalary
        {
            get { return weekSalary; }
            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                weekSalary = value;
            }
        }

        public decimal HoursPerDay
        {
            get { return hoursPerDay; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                hoursPerDay = value;
            }
        }

        public Worker(string firstName, string lastName, decimal weekSalary, decimal hoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.HoursPerDay = hoursPerDay;
        }

        public decimal CalcSalaryPerHour()
        {
            return this.weekSalary / (this.hoursPerDay * 5);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"First Name: {this.FirstName}");
            sb.AppendLine($"Last Name: {this.LastName}");
            sb.AppendLine($"Week Salary: {this.WeekSalary:f2}");
            sb.AppendLine($"Hours per day: {this.HoursPerDay:f2}");
            sb.AppendLine($"Salary per hour: {this.CalcSalaryPerHour():f2}");
            return sb.ToString();
        }
    }
}