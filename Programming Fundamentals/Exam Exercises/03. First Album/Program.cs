using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._First_Album
{
    class Program
    {
        static void Main(string[] args)
        {
            //ще получавам input-и, които може да съдържат всички ASCII символи. Задачата ми е да намеря кои песни могат да бъдат включени в дебютния албум на бандата.
            //За валидни се считат песните които съдържат трите елемента - Име, текст, дължина.
            //1.Името може да съдържа - всички букви, празно място и тире, но не трябва нито да започва, нито да завършва с празно място и тире. Името на песнета ще се намира между скобите [].
            //2.Текстът на песента ще се намира между кавичките "" и може да съдържа всяка буква и празно място.
            //3.Дължината на песента се счита за валидна когато е зададена в един от следните формати
            //•	In minutes – {minutes}:{seconds}m -> example: 0:44m; 10:05m;
            //•	In seconds- {seconds}s -> example: 35s; 123s;
            //песента е валидна когато и трите елемента се съдържат в input-а, но тяхното място може да варира.
            //Програматa трябва да приключи когато се намерят 4 валидни песни, или когато получи команда "Rock on!".
            //Трябва да принтира всички валидни песни във формат: {name} -> {length} => {lyrics}

            var lyricsPattern = @"""([\w ]+)""";
            var nameOfSongPattern = @"\[([\w][\w- ]+)\]";
            var timePattern = @"(([0-9]{1,2}:[0-9]{2})m)|(([0-9]{1,4})s)";

            string inputLine;
            var validSongs = new List<string>();

            while ((inputLine = Console.ReadLine()) != "Rock on!")
            {
                string result = "";
                Regex lyricsMatch = new Regex(lyricsPattern);
                Match lyrics = lyricsMatch.Match(inputLine);
                if (lyrics.Success)
                {
                    var lyricsItself = lyrics.Groups[1];
                    Regex nameMatch = new Regex(nameOfSongPattern);
                    Match name = nameMatch.Match(inputLine);
                    if (name.Success)
                    {
                        var nameItself = name.Groups[1];
                        Regex timeMatch = new Regex(timePattern);
                        Match time = timeMatch.Match(inputLine);
                        if (time.Success)
                        {
                            string timeItself = "";
                            if (time.Groups[1].Length == 0) // group 1 is null demek imame sekundi samo
                            {
                                timeItself = time.Groups[4].ToString();

                                int totalSeconds = int.Parse(timeItself);
                                string seconds = (totalSeconds % 60).ToString("D2");
                                string minutes = (totalSeconds / 60).ToString("D2");
                                timeItself = $"{minutes}:{seconds}";
                            }
                            else
                            {
                                timeItself = time.Groups[2].ToString();
                            }
                            validSongs.Add($"{nameItself} -> {timeItself} => {lyricsItself}");
                        }
                    }
                }
            }
            foreach (var a in validSongs)
            {
                Console.WriteLine(a);
            }
        }
    }
}