using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _05._Book_Library
{
    class AuthorInfo
    {
        public string Author { get; set; }
        public double Sales { get; set; }
    }

    class Book
    {
        public Book(string name, string author, string publisher, DateTime releaseDate, string isbn, double price)
        {
            Name = name;
            Author = author;
            Publisher = publisher;
            ReleaseDate = releaseDate;
            Isbn = isbn;
            Price = price;
        }

        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Isbn { get; set; }
        public double Price { get; set; }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var library = new Library()
            {
                Name = "Prosveta",
                Books = new List<Book>()
            };
            int numOfBooks = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfBooks; i++)
            {
                var input = Console.ReadLine().Split();

                var name = input[0];
                var author = input[1];
                var publisher = input[2];
                var releaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                var isbn = input[4];
                double price = double.Parse(input[5]);

                var book = new Book(name, author, publisher, releaseDate, isbn, price);

                library.Books.Add(book);
            }
            var authorSales = new List<AuthorInfo>();
            var authors = library.Books.Select(a => a.Author).Distinct().ToArray();

            foreach (var author in authors)
            {
                var sales = library.Books.Where(a => a.Author == author).Sum(a => a.Price);

                var authorInfo = new AuthorInfo
                {
                    Author = author,
                    Sales = sales
                };
                authorSales.Add(authorInfo);
            }
            authorSales = authorSales.OrderByDescending(a => a.Sales).ThenBy(a => a.Author).ToList();
            foreach (var authorSale in authorSales)
            {
                Console.WriteLine($"{authorSale.Author} -> {authorSale.Sales:f2}");
            }
        }
    }
}