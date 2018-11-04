namespace BirthdayCelebrations.Models
{
    using System;
    using BirthdayCelebrations.Contracts;

    public class Pet : IName, IBirthable
    {
        public string Name { get; }
        public DateTime Birthdate { get; }

        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = DateTime.ParseExact(birthdate, "dd/mm/yyyy", null);
        }
    }
}