namespace CompanyRoster
{
    public class Employee
    {
        private string name;
        private decimal salary;
        private Department department;
        private string position;
        private string email = "n/a";
        private int age = -1;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Employee(string name, string position, decimal salary, int age, string email)
        {
            Name = name;
            Position = position;
            Salary = salary;
            Age = age;
            Email = email;
        }
    }
}