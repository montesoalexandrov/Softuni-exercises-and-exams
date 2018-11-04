﻿namespace FoodShortage.Models
{
    using FoodShortage.Contracts;
    using BirthdayCelebrations.Contracts;

    public class Rebel : IName, IBuyer
    {
        public string Name { get; }
        public int Age { get; }
        public string Group { get; }
        public int Food { get; private set; }

        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}