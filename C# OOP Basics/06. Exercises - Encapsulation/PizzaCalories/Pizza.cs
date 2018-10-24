namespace PizzaCalories
{
    using System;
    using System.Collections.Generic;

    public class Pizza
    {
        private string name;
        private Queue<Topping> toppings;
        private Dough dough;

        public string Name
        {
            get { return name; }
            set
            {
                if (value?.Length < 1 || value?.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }
        
        public Queue<Topping> Toppings
        {
            get
            {
                if (toppings.Count < 0 || toppings.Count > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
                return toppings;
            }
        }

        public Dough Dough
        {
            get { return dough; }
            set { dough = value; }
        }

        public Pizza(string name, Dough dough)
        {
            Name = name;
            toppings = new Queue<Topping>();
            this.dough = dough;
        }

        public double CalculateCalories()
        {
            double totalCalories = 0;
            totalCalories += dough.Calories;
            foreach (Topping topping in toppings)
            {
                totalCalories += topping.Calories;
            }

            return totalCalories;
        }
    }
}