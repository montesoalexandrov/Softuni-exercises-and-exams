using System;
using System.Globalization;
using System.Linq;

namespace _01.Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var holidays = new[]
            {
                "01 01",
                "01 05",
                "03 03",
                "06 05",
                "24 05",
                "06 09",
                "22 09",
                "01 11",
                "24 12",
                "25 12",
                "26 12"
            }.Select(a => DateTime.ParseExact(a, "dd MM", CultureInfo.InvariantCulture)).ToArray();
            var startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var workingDaysCount = 0;
            for (DateTime currentDate = startDate; startDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                var isSaturdayOrSunday = currentDate.DayOfWeek == DayOfWeek.Saturday || currentDate.DayOfWeek == DayOfWeek.Sunday;
                var isHoliday = holidays.Any(d => d.Day == currentDate.Day && d.Month == currentDate.Month);

                var isWorkingDay = !(isSaturdayOrSunday || isHoliday);

                if (isWorkingDay)
                {
                    workingDaysCount++;
                }
            }
            Console.WriteLine(workingDaysCount);
        }
    }
}