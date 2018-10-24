﻿using System;
using System.Collections.Generic;

namespace PersonsInfo
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam = new List<Person>();
        private List<Person> reserveTeam = new List<Person>();

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public IReadOnlyCollection<Person> FirstTeam
        {
            get { return firstTeam; }
        }

        public IReadOnlyCollection<Person> ReserveTeam
        {
            get { return reserveTeam; }
        }

        public Team(string name)
        {
            this.name = name;
        }

        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                firstTeam.Add(person);
            }
            else
            {
                reserveTeam.Add(person);
            }
        }
    }
}