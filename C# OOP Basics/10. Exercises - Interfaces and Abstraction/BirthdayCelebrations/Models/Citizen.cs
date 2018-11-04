namespace BirthdayCelebrations.Models
{
    using System;
    using BirthdayCelebrations.Contracts;

    public class Citizen : IIdentifiable, IName, IBirthable
    {
        public string Name { get; }
        public int Age { get; }
        public string Id { get; }
        public DateTime Birthdate { get; }

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Age = age;
            this.Name = name;
            this.Id = id;
            this.Birthdate = DateTime.ParseExact(birthdate, "dd/mm/yyyy", null);
        }
    }
}