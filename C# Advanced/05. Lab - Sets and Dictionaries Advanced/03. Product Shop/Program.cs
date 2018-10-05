using System;
using System.Collections.Generic;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shops = new SortedDictionary<string, Dictionary<string, double>>();

            var input = string.Empty;

            while ((input = Console.ReadLine()) != "Revision")
            {
                var tokens = input.Split(", ");
                var shopName = tokens[0];
                var productName = tokens[1];
                var productPrice = double.Parse(tokens[2]);

                if (!shops.ContainsKey(shopName))
                {
                    shops.Add(shopName, new Dictionary<string, double>());
                }

                shops[shopName].Add(productName, productPrice);
            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var products in shop.Value)
                {
                    Console.WriteLine($"Product: {products.Key}, Price: {products.Value}");
                }
            }
        }
    }
}