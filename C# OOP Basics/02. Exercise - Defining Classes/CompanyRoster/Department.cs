using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    class Department
    {
        private List<Employee> employees;
        string name;

        public Department(string name)
        {
            Employees = new List<Employee>();
            Name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public List<Employee> Employees
        {
            get { return employees; }
            private set { employees = value; }
        }

        public decimal AverageSalary
        {
            get
            {
                return Employees.Select(e => e.Salary).Average();
            }
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
    }
}
