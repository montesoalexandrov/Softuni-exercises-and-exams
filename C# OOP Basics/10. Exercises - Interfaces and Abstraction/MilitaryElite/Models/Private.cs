namespace MilitaryElite.Models
{
    using MilitaryElite.Contracts;

    public class Private : Soldier, IPrivate
    {
        private decimal salary;

        public Private(int id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        //TODO add validation
        public decimal Salary
        {
            get => this.salary;
            private set => this.salary = value;
        }

        public override string ToString()
        {
            return base.ToString() + $"Salary: {this.Salary:F2}";
        }
    }
}