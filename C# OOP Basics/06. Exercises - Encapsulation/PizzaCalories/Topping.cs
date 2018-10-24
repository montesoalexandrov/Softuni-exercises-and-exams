namespace PizzaCalories
{
    using System;

    public class Topping
    {
        private string type;
        private double weight;
        private double calories;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value < 0 || value > 50)
                {
                    throw new ArgumentException($"{type} weight should be in the range [1..50].");
                }
                weight = value;
            }
        }

        public double Calories
        {
            get { return calories; }
            set { calories = value; }
        }

        public Topping(string type, double weight)
        {
            this.type = type;
            Weight = weight;
            calories = CalculateCalories();
        }

        private double GetModifier()
        {
            switch (type.ToLower())
            {
                case "meat":
                    return 2 * 1.2;
                case "veggies":
                    return 2 * 0.8;
                case "cheese":
                    return 2 * 1.1;
                case "sauce":
                    return 2 * 0.9;
                default:
                    throw new ArgumentException($"Cannot place {type} on top of your pizza.");
            }
        }

        private double CalculateCalories()
        {
            return weight * GetModifier();
        }
    }
}