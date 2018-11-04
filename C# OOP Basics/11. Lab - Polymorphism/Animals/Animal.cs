namespace Animals
{
    public abstract class Animal
    {
        public string Name { get; protected set; }
        public string FavouriteFood { get; protected set; }

        protected Animal(string name, string favouriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favouriteFood;
        }

        public virtual string ExplainSelf()
        {
            string result = $"I am {this.Name} and my favourite food is {this.FavouriteFood}";
            return result;
        }
    }
}