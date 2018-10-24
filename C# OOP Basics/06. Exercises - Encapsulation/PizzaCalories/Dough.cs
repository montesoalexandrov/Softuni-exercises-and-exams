namespace PizzaCalories
{
    using System;

    public class Dough
    {
        private string flour;
        private string technique;
        private double weight;
        private double calories;

        public string Flour
        {
            get { return flour; }
            set { flour = value; }
        }

        public string Technique
        {
            get { return technique; }
            set { technique = value; }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }

        public double Calories
        {
            get { return calories; }
            set { calories = value; }
        }

        public Dough(string flour, string technique, double weight)
        {
            this.flour = flour;
            this.technique = technique;
            Weight = weight;
            calories = CalculateCalories();
        }

        private double GetFlourModifier()
        {
            switch (flour.ToLower())
            {
                case "white":
                    return 1.5;
                case "wholegrain":
                    return 1.0;
                default:
                    throw new ArgumentException("Invalid type of dough.");
            }
        }

        private double GetTechniqueModifier()
        {
            switch (technique.ToLower())
            {
                case "crispy":
                    return 0.9;
                case "chewy":
                    return 1.1;
                case "homemade":
                    return 1.0;
                default:
                    throw new ArgumentException("Invalid type of dough.");
            }
        }

        private double CalculateCalories()
        {
            return (2.0 * weight) * GetFlourModifier() * GetTechniqueModifier();
        }
    }
}