using System;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var filterTime = int.Parse(Console.ReadLine());
            var percent = int.Parse(Console.ReadLine());
            var uploadTime = int.Parse(Console.ReadLine());

            var filteredPictures = (long)(Math.Ceiling(percent * (number / 100d)));
            var timeAllPictures = (long)number * filterTime;
            var timeUploadPictures = filteredPictures * uploadTime;
            var totalTime = timeAllPictures + timeUploadPictures;
            TimeSpan t = TimeSpan.FromSeconds(totalTime);
            string time = string.Format("{0}:{1:D2}:{2:D2}:{3:D2}",
                            t.Days,
                            t.Hours,
                            t.Minutes,
                            t.Seconds);
            Console.WriteLine(time);
        }
    }
}
