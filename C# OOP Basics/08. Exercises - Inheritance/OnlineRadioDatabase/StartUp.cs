namespace OnlineRadioDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            var playlist = new Queue<Song>();

            for (int counter = 0; counter < numberOfSongs; counter++)
            {
                var songTokens = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                try
                {
                    var songLenTokens = songTokens[2] .Split(':').ToArray();

                    int minutes;
                    int seconds;
                    if (int.TryParse(songLenTokens[0], out minutes) && int.TryParse(songLenTokens[1], out seconds))
                    {
                        playlist.Enqueue(new Song(songTokens[0], songTokens[1], minutes, seconds));
                        Console.WriteLine("Song added.");
                    }
                    else
                    {
                        throw new ArgumentException("Invalid song length.");
                    }
                }
                catch (ArgumentException ArgEx)
                {
                    Console.WriteLine(ArgEx.Message);
                }
            }

            int totalPlaylistLength = 0;
            foreach (var song in playlist)
            {
                totalPlaylistLength += song.Minutes * 60 + song.Seconds;
            }
            int totalMinutes = totalPlaylistLength / 60;
            int totalSeconds = totalPlaylistLength % 60;
            int hours = totalMinutes / 60;
            totalMinutes %= 60;

            Console.WriteLine($"Songs added: {playlist.Count}");
            Console.WriteLine($"Playlist length: {hours}h {totalMinutes}m {totalSeconds}s");
        }
    }
}