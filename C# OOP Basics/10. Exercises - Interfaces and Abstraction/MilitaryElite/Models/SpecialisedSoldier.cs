namespace MilitaryElite.Models
{
    using MilitaryElite.Enums;
    using MilitaryElite.Contracts;

    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, Corps corps)
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        public Corps Corps { get; }
    }
}