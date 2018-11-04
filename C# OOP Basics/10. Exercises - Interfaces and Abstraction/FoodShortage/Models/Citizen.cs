namespace BirthdayCelebrations.Models
{
    using System;
    using FoodShortage.Contracts;
    using BirthdayCelebrations.Contracts;

    public class Citizen : IIdentifiable, IName, IBirthable, IBuyer
    {
        public string Name { get; }
        public int Age { get; }
        public string Id { get; }
        public DateTime Birthdate { get; }
        public int Food { get; private set; }

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Age = age;
            this.Name = name;
            this.Id = id;
            this.Birthdate = DateTime.ParseExact(birthdate, "dd/mm/yyyy", null);
        }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}