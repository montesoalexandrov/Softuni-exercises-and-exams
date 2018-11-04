namespace MilitaryElite.Models
{
    using MilitaryElite.Contracts;
    using System.Collections.Generic;

    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        public LeutenantGeneral(int id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName, salary)
        {
            this.Privates = new List<IPrivate>();
        }
        
        public ICollection<IPrivate> Privates { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"\nPrivates:{(this.Privates.Count == 0 ? "" : "\n  ")}{string.Join("\n  ", this.Privates)}";
        }
    }
}
