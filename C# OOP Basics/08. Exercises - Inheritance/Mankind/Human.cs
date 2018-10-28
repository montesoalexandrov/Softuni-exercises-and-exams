﻿namespace Mankind
{
    using System;

    public class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (char.IsLower(value[0]))
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: {nameof(firstName)}");
                }

                if (value?.Length < 4)
                {
                    throw new ArgumentException($"Expected length at least 4 symbols! Argument: {nameof(firstName)}");
                }
                firstName = value;
            }
        }


        public string LastName
        {
            get { return lastName; }
            set
            {
                if (char.IsLower(value[0]))
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: {nameof(lastName)}");
                }

                if (value?.Length < 3)
                {
                    throw new ArgumentException($"Expected length at least 3 symbols! Argument: {nameof(lastName)}");
                }
                lastName = value;
            }
        }

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}