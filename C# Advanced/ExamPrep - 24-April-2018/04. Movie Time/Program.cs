using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Movie_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            string favouriteGenre = Console.ReadLine();
            string favouriteDuration = Console.ReadLine();
            string input = string.Empty;
            var movies = new Dictionary<string, TimeSpan>();
            var totalPlaylist = new Queue<TimeSpan>();

            while ((input = Console.ReadLine()) != "POPCORN!")
            {
                string[] tokens = input.Split('|');
                string name = tokens[0];
                string genre = tokens[1];
                string[] durationData = tokens[2].Split(':');
                TimeSpan duration = new TimeSpan(int.Parse(durationData[0]), int.Parse(durationData[1]), int.Parse(durationData[2]));

                if (genre == favouriteGenre)
                {
                    movies.Add(name, duration);
                }
                totalPlaylist.Enqueue(duration);
            }

            TimeSpan totalPlaylistDuration = new TimeSpan(totalPlaylist.Sum(r => r.Ticks));

            if (favouriteDuration == "Short")
            {
                foreach (var movie in movies.OrderBy(x => x.Value))
                {
                    Console.WriteLine(movie.Key);
                    input = Console.ReadLine();
                    PrintResult(input, totalPlaylistDuration, movie);
                }
            }
            else if (favouriteDuration == "Long")
            {
                foreach (var movie in movies.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine(movie.Key);
                    input = Console.ReadLine();
                    PrintResult(input, totalPlaylistDuration, movie);
                }
            }
        }

        private static void PrintResult(string input, TimeSpan totalPlaylistDuration, KeyValuePair<string, TimeSpan> movie)
        {
            if (input == "Yes")
            {
                Console.WriteLine($"We're watching {movie.Key} - {movie.Value}");
                Console.WriteLine($"Total Playlist Duration: {totalPlaylistDuration}");
                Environment.Exit(0);
            }
        }
    }
}