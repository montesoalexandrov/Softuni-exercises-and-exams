namespace CatShop.Models
{
	using System.ComponentModel.DataAnnotations;

	public class Cat
    {
		[Key]
		public int Id { get; set; }

		public string Name { get; set; }

		public string Nickname { get; set; }

		public double Price { get; set; }

		public Cat()
		{
		}

		public Cat(string name, string nickname, double price)
		{
			this.Name = name;
			this.Nickname = name;
			this.Price = price;
		}
	}
}
