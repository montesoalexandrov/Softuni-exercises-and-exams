using System;

namespace _02._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            var phrases = new[]
            {   "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            var events = new[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            var authors = new[]
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            var cities = new[]
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            int index = int.Parse(Console.ReadLine());

            for (int i = 0; i < index; i++)
            {
                Random rnd = new Random();
                var phrase = rnd.Next(phrases.Length);
                var eventt = rnd.Next(events.Length);
                var author = rnd.Next(authors.Length);
                var city = rnd.Next(cities.Length);
                Console.WriteLine($"{phrases[phrase]} {events[eventt]} {authors[author]} {cities[city]}");
            }
        }
    }
}
