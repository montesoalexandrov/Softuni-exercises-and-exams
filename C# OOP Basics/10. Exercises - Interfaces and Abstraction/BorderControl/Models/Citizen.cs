﻿namespace BorderControl.Models
{
    using BorderControl.Contracts;

    public class Citizen : IIdentifiable
    {
        public string Name { get; }
        public int Age { get; }
        public string Id { get; }

        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }
    } 
}